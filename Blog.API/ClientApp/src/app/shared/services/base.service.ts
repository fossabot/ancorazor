import { Injectable, OnDestroy } from "@angular/core";
import { environment } from "src/environments/environment";
import { AxiosResponse, AxiosRequestConfig } from "axios";
import { ResponseResult } from "../models/response-result";
import axios from "axios";
import { LoggingService } from "./logging.service";
import { SGUtil } from "../utils/siegrain.utils";
import { Store } from "../store/store";
import { TaskWrapper } from "./async-helper.service";
import { TransferState, makeStateKey } from "@angular/platform-browser";
import { Router } from "@angular/router";
import { Subscription } from "rxjs";
import { SGProgress } from "../utils/siegrain.progress";

@Injectable({
  providedIn: "root"
})
export abstract class BaseService implements OnDestroy {
  protected subscription = new Subscription();

  constructor(
    private _wrapper: TaskWrapper,
    private _state: TransferState,
    private _progress: SGProgress,
    protected util: SGUtil,
    protected route: Router,
    protected logger: LoggingService,
    protected store: Store
  ) {
    this.setupAxios();
    this.initialize();
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  protected setupAxios() {
    axios.defaults.baseURL = environment.apiUrlBase;
    axios.defaults.timeout = 100000;
    axios.defaults.headers = { "Content-Type": "application/json" };
    axios.interceptors.request.use(_ => {
      this._progress.progressStart();
      return _;
    });
    axios.interceptors.response.use(_ => {
      this._progress.progressDone();
      return _;
    });
  }

  /**
   * initialize for child services
   */
  protected abstract initialize();

  async get(
    url: string,
    query?: any,
    option?: AxiosRequestConfig
  ): Promise<ResponseResult> {
    /**
     * Mark: 让 Server side 的请求结果传递到 Client side 避免重复请求
     * https://medium.com/@evertonrobertoauler/angular-5-universal-with-transfer-state-using-angular-cli-19fe1e1d352c
     */
    const stateKey = makeStateKey(url);
    let storedData = this._state.get(stateKey, null);
    if (storedData) {
      this._state.remove(stateKey);
      var response = storedData as ResponseResult;
      if (response.succeed) {
        this.logger.info("server side state detected: ", storedData);
        return Promise.resolve(storedData as ResponseResult);
      } else {
        this.logger.error("server side request failed: ", storedData);
      }
    }

    /**
     * Mark: 让 universal 等待 API 请求并渲染完毕
     * https://github.com/angular/angular/issues/20520#issuecomment-449597926
     */
    return new Promise<ResponseResult>(resolve => {
      if (!this.store.renderFromClient)
        this.logger.info(
          "Server side requesting",
          `${environment.apiUrlBase}/${url}`
        );
      this._wrapper
        .doTask(this.handleRequest(Methods.GET, url, null, query))
        .subscribe(result => {
          if (!this.store.renderFromClient) {
            this._state.set(stateKey, result);
            this.logger.info("transfer state stored: ", result);
          }
          resolve(result);
        });
    });
  }

  async post(
    url: string,
    body: any,
    query?: any,
    option?: AxiosRequestConfig
  ): Promise<ResponseResult> {
    return await this.handleRequest(Methods.POST, url, body, query);
  }

  async put(
    url: string,
    body?: any,
    query?: any,
    option?: AxiosRequestConfig
  ): Promise<ResponseResult> {
    return await this.handleRequest(Methods.PUT, url, body, query);
  }

  async delete(
    url: string,
    query?: any,
    option?: AxiosRequestConfig
  ): Promise<ResponseResult> {
    return await this.handleRequest(Methods.DELETE, url, null, query);
  }

  /**
   * 请求处理
   * @param method Method
   * @param url URL
   * @param body Payload
   * @param query QueryString
   * @param option 选项（未实装）
   */
  async handleRequest(
    method: Methods,
    url: string,
    body?: any,
    query?: any
  ): Promise<ResponseResult> {
    try {
      const res = await axios.request({
        method: method.toString(),
        url: url,
        params: query,
        data: body,
        withCredentials: false
      });
      return this.handleResponse(res);
    } catch (error) {
      if (error.response) {
        return this.handleResponse(error.response as AxiosResponse);
      } else {
        this.util.tip(error);
        this.logger.error(error);
        return new ResponseResult({
          message: `${error.message} for url: ${error.request.url}`
        });
      }
    }
  }

  /**
   * 响应处理
   * @param response
   */
  handleResponse(response: AxiosResponse): ResponseResult {
    let result: ResponseResult = null;
    if (response.status >= 200 && response.status < 300)
      result = new ResponseResult({
        data: response.data.data,
        succeed: response.data.succeed,
        message: response.data.message
      });
    else {
      return this.handleError(
        new ResponseResult({
          message: `Request failed : ${response.status} ${response.statusText}`,
          data: response.data
        }),
        response.status
      );
    }

    if (result.succeed) return result;
    else return this.handleError(new ResponseResult(result));
  }

  /**
   * 错误处理
   * @param result
   */
  handleError(result: ResponseResult, code?: number): ResponseResult {
    switch (code) {
      case 401:
        this.util.tip("Session expired, please sign-in again.");
        this.store.signOut();
        this.route.navigate([], { fragment: "sign-in" });
        break;
      default:
        this.util.tip(result.message);
        this.logger.error(result);
    }
    return new ResponseResult(result);
  }
}

export interface ISubService {
  /** 服务名称 */
  serviceName: string;
}

const enum Methods {
  GET = "GET",
  POST = "POST",
  PUT = "PUT",
  DELETE = "DELETE"
}
