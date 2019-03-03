import { Injectable } from "@angular/core";
import { BehaviorSubject, Observable } from "rxjs";

import { IMovie, ICreateMovie, IUpdateMovie, IPopularMovie } from "../models/movie.interface";
import { MovieListsService } from "./movie-lists.service";
import { ItheaterHttpService } from "./itheater.http.service";
import { MoviesDbService } from "./moviesdb.http.service";
import { tap, shareReplay } from "rxjs/operators";

@Injectable()
export class MoviesService {
  private popularMoviesSubject: BehaviorSubject<IPopularMovie[]>;
  public popularMovies$: Observable<IPopularMovie[]>;

  constructor(
    private iTheaterService: ItheaterHttpService,
    private moviesDbService: MoviesDbService,
    private movieListsService: MovieListsService
  ) {
    this.popularMoviesSubject = new BehaviorSubject<IPopularMovie[]>([]);
    this.popularMovies$ = this.popularMoviesSubject.asObservable();
  }

  search(query: string) {
    return this.moviesDbService.search(query);
  }

  getMovieById(movieDbId: number) {
    return this.moviesDbService.getMovie(movieDbId);
  }

  getPopularMovies(page) {
    return this.moviesDbService
      .getPopular(page)
      .subscribe(data => this.popularMoviesSubject.next(data));
  }

  addMovieToList(movie: ICreateMovie) {
    return this.iTheaterService.addMovieToList(movie).pipe(
      tap(data => this.movieListsService.addMovieToList(data)),
      shareReplay()
    );
  }

  updateMovie(id: number, movie: IUpdateMovie) {
    return this.iTheaterService.updateMovie(id, movie).pipe(
      tap(data => this.movieListsService.updateMovieOnList(data)),
      shareReplay()
    );
  }

  deleteMovie(id: number) {
    return this.iTheaterService.deleteMovie(id).pipe(
      tap(() => this.movieListsService.deleteMovieFromList(id)),
      shareReplay()
    );
  }
}
