import { NgModule } from "@angular/core";
import { AuthGuard } from "./guards/auth.guard";
import { HTTP_INTERCEPTORS } from "@angular/common/http";
import { JwtInterceptor } from "./interceptors/jwt.interceptor";
import { ReverseAuthGuard } from './guards/reverse.auth.guard';
import { AuthService } from "./services/auth.service";
import { MovieListsService } from './services/movie-lists.service';
import { MoviesService } from './services/movies.service';
import { ItheaterHttpService } from './services/itheater.http.service';
import { MoviesDbService } from './services/moviesdb.http.service';

@NgModule({
  providers: [
    AuthService,
    ItheaterHttpService,
    MoviesDbService,
    MoviesService,
    MovieListsService,
    AuthGuard,
    ReverseAuthGuard,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ]
})
export class CoreModule {}
