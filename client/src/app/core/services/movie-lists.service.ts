import { Injectable } from "@angular/core";
import { BehaviorSubject, Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { tap, map, shareReplay } from "rxjs/operators";
import {
  IMovieList,
  ICreateMovieList,
  IUpdateMovieList
} from "../models/movie-list.interface";
import { IMovie } from "../models/movie.interface";
import { ItheaterHttpService } from "./itheater.http.service";

@Injectable()
export class MovieListsService {
  // List of movies
  private movieListsSubject: BehaviorSubject<IMovieList[]>;
  public movieLists$: Observable<IMovieList[]>;

  // Current selected movie list
  private currentMovieListSubject: BehaviorSubject<IMovieList>;
  public currentMovieList$: Observable<IMovieList>;

  // Movies in current selected movie list
  private moviesInCurrentListSubject: BehaviorSubject<IMovie[]>;
  public moviesInCurrentList$: Observable<IMovie[]>;

  private movieListUrl = environment.serverUrl + "api/movielists/";

  constructor(private iTheaterService: ItheaterHttpService) {
    // Instantiate observables
    this.movieListsSubject = new BehaviorSubject<IMovieList[]>(null);
    this.movieLists$ = this.movieListsSubject.asObservable();

    this.currentMovieListSubject = new BehaviorSubject<IMovieList>(null);
    this.currentMovieList$ = this.currentMovieListSubject.asObservable();

    this.moviesInCurrentListSubject = new BehaviorSubject<IMovie[]>([]);
    this.moviesInCurrentList$ = this.moviesInCurrentListSubject.asObservable();
  }

  getMovieLists() {
    return this.iTheaterService.getMovieLists().pipe(
      tap(data => {
        data.reverse(); // Place recently added first
        this.movieListsSubject.next(data);
      })
    );
  }

  getMoviesOnListBySlug(slug: string) {
    return this.iTheaterService.getMoviesOnListBySlug(slug).pipe(
      tap(data => this.moviesInCurrentListSubject.next(data)),
      shareReplay()
    );
  }

  // Search for movie list in MovieListsSubject
  // Call this first before calling getMovieList
  searchForMovieList(slug: string) {
    if (this.movieListsSubject.value) {
      return this.movieListsSubject.value.find(
        _movieList => _movieList.slug === slug
      );
    }
    return null;
  }

  // Optionally use this method after calling searchForMovieList
  saveCurrentList(movieList: IMovieList) {
    this.currentMovieListSubject.next(movieList);
  }

  getMovieList(slug: string) {
    return this.iTheaterService.getMovieListBySLug(slug).pipe(
      tap(data => this.currentMovieListSubject.next(data)),
      shareReplay()
    );
  }

  createMovieList(movieList: ICreateMovieList) {
    return this.iTheaterService.createMovieList(movieList).pipe(
      tap(data =>
        this.movieListsSubject.next([data, ...this.movieListsSubject.value])
      ),
      map((data: IMovieList) => data.slug),
      shareReplay()
    );
  }

  updateMovieList(movieListId: number, movieList: IUpdateMovieList) {
    return this.iTheaterService
      .updateMovieList(movieListId, movieList)
      .subscribe(data => this.updateListInMovieLists(data));
  }

  deleteMovieList(movieListId: number) {
    return this.iTheaterService
      .deleteMovieList(movieListId)
      .subscribe(() => this.deleteListFromMovieLists(movieListId));
  }

  private updateListInMovieLists(movieList: IMovieList) {
    if (
      this.currentMovieListSubject.value &&
      this.currentMovieListSubject.value.id === movieList.id
    ) {
      this.currentMovieListSubject.next(movieList);
    }

    if (this.movieListsSubject.value) {
      const updatedList = this.movieListsSubject.value.map(_movieList => {
        if (_movieList.id === movieList.id) {
          return movieList;
        }
        return _movieList;
      });
      this.movieListsSubject.next(updatedList);
    }
  }

  private deleteListFromMovieLists(movieListId: number) {
    if (
      this.currentMovieListSubject.value &&
      this.currentMovieListSubject.value.id === movieListId
    ) {
      this.currentMovieListSubject.next(null);
    }

    if (this.movieListsSubject.value) {
      const updatedList = this.movieListsSubject.value.filter(
        _movieList => _movieList.id !== movieListId
      );
      this.movieListsSubject.next(updatedList);
    }
  }

  public addMovieToList(movie: IMovie) {
    const currentMovies = this.moviesInCurrentListSubject.value;

    if (currentMovies === null) {
      // This case, in general. Should not happen.
      this.moviesInCurrentListSubject.next([movie]);
    } else {
      this.moviesInCurrentListSubject.next([movie, ...currentMovies]);
    }
  }

  public updateMovieOnList(movie: IMovie) {
    const currentMovies = this.moviesInCurrentListSubject.value;
    if (currentMovies === null) {
      // This case, in general. Should not happen.
      this.moviesInCurrentListSubject.next([movie]);
    } else {
      this.moviesInCurrentListSubject.next(
        currentMovies.map(_movie => {
          return _movie.id === movie.id ? movie : _movie;
        })
      );
    }
  }

  public deleteMovieFromList(movieId: number) {
    const currentMovies = this.moviesInCurrentListSubject.value;
    if (currentMovies) {
      this.moviesInCurrentListSubject.next(
        currentMovies.filter(_movie => _movie.id != movieId)
      );
    }
  }
}
