import { Injectable } from "@angular/core";
import { BaseService, ISubService } from "src/app/shared/services/base.service";
import { ArticleParameters } from "../models/article-parameters";
import { PagedResult } from "src/app/shared/models/response-result";
import ArticleModel from "../models/article-model";

@Injectable({
  providedIn: "root"
})
export class ArticleService extends BaseService implements ISubService {
  serviceName = "article";

  async getPagedArticles(
    params?: ArticleParameters
  ): Promise<PagedResult<ArticleModel>> {
    var res = await this.get(this.serviceName, params);
    return res.succeed && (res.data as PagedResult<ArticleModel>);
  }

  async getArticle(id: number): Promise<ArticleModel> {
    var res = await this.get(`${this.serviceName}/${id}`);
    return res.succeed && (res.data as ArticleModel);
  }

  async add(params?: ArticleModel): Promise<ArticleModel> {
    var res = await this.post(this.serviceName, params);
    return res.succeed && (res.data as ArticleModel);
  }

  async update(params?: ArticleModel): Promise<ArticleModel> {
    var res = await this.put(this.serviceName, params);
    return res.succeed && (res.data as ArticleModel);
  }

  async remove(id: number): Promise<boolean> {
    var res = await this.delete(`${this.serviceName}/${id}`);
    return Promise.resolve(res.succeed);
  }
}