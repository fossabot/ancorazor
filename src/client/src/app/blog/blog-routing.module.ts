import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { BlogAppComponent } from "./blog-app.component";
import { ArticleListComponent } from "./components/article-list/article-list.component";
import { RequireAuthenticatedUserRouteGuard } from "../shared/oidc/require-authenticated-user-route.guard";
import { WriteArticleComponent } from "./components/write-article/write-article.component";

const routes: Routes = [
  {
    path: "",
    component: BlogAppComponent,
    children: [
      { path: "list", component: ArticleListComponent },
      /**
       * Mark: canActivate，在进入这个路由之前需要做的操作
       * 在这里就是鉴权，其实这一坨就是类似Attribute的东西，也可以有多个
       */
      {
        path: "add",
        component: WriteArticleComponent,
        canActivate: [RequireAuthenticatedUserRouteGuard]
      },
      { path: "**", redirectTo: "list" }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BlogRoutingModule {}