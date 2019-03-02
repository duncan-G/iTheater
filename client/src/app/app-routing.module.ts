import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ReverseAuthGuard } from "./core/guards/reverse.auth.guard";
import { AuthGuard } from "./core/guards/auth.guard";

const routes: Routes = [
  {
    path: "",
    loadChildren: "./main/landing/landing.module#LandingModule"
  },
  {
    path: "",
    loadChildren: "./main/login/login.module#LoginModule",
    canActivate: [ReverseAuthGuard]
  },
  {
    path: "",
    loadChildren: "./main/register/register.module#RegisterModule",
    canActivate: [ReverseAuthGuard]
  },
  {
    path: "",
    loadChildren:
      "./main/reset-password/reset-password.module#ResetPasswordModule",
    canActivate: [ReverseAuthGuard]
  },
  {
    path: "",
    loadChildren: "./main/movie-lists/movie-lists.module#MovieListsModule",
    canActivate: [AuthGuard]
  },
  {
    path: "",
    loadChildren: "./main/movie-list/movie-list.module#MovieListModule"
  },
  {
    path: "",
    loadChildren: "./main/movie/movie.module#MovieModule"
  },
  { path: "**", redirectTo: "/error-404" }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      scrollPositionRestoration: "enabled",
      anchorScrolling: "enabled"
    })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
