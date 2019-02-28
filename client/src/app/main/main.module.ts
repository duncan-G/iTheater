import { NgModule } from "@angular/core";
import { LoginModule } from "./login/login.module";
import { LandingModule } from "./landing/landing.module";
import { RegisterModule } from "./register/register.module";
import { ResetPasswordModule } from "./reset-password/reset-password.module";
import { MovieListModule } from "./movie-list/movie-list.module";
import { Page404Module } from './page404/page404.module';
import { Page500Module } from './page500/page500.module';

@NgModule({
  imports: [
    LoginModule,
    LandingModule,
    MovieListModule,
    Page404Module,
    Page500Module,
    RegisterModule,
    ResetPasswordModule
  ]
})
export class MainModule {}
