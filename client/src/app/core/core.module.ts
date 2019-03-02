import { NgModule } from "@angular/core";
import { AuthGuard } from "./guards/auth.guard";
import { HTTP_INTERCEPTORS } from "@angular/common/http";
import { JwtInterceptor } from "./interceptors/jwt.interceptor";
import { ReverseAuthGuard } from './guards/reverse.auth.guard';
import { AuthService } from "./services/auth.service";
import { MovieListsService } from './services/movie-lists.service';
import { MoviesService } from './services/movies.service';

@NgModule({
  providers: [
    AuthService,
    MoviesService,
    MovieListsService,
    AuthGuard,
    ReverseAuthGuard,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ]
})
export class CoreModule {}
