import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BehaviorSubject, Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { tap, map, shareReplay } from "rxjs/operators";
import { MovieList } from "../models/movie-list.interface";
import { Movie } from "../models/movie.interface";

@Injectable()
export class MovieListsService {
  // List of movies
  private movieListsSubject: BehaviorSubject<MovieList[]>;
  public movieLists: Observable<MovieList[]>;

  // Current selected movie list
  private currentMovieListSubject: BehaviorSubject<MovieList>;
  public currentMovieList$: Observable<MovieList>;

  // Movies in current selected movie list
  private moviesInCurrentListSubject: BehaviorSubject<Movie[]>;
  public moviesInCurrentList$: Observable<Movie[]>;

  private movieListUrl = environment.serverUrl + "api/movielists/";

  constructor(private http: HttpClient) {
    // Instantiate observables
    this.movieListsSubject = new BehaviorSubject<MovieList[]>(null);
    this.movieLists = this.movieListsSubject.asObservable();

    this.currentMovieListSubject = new BehaviorSubject<MovieList>(null);
    this.currentMovieList$ = this.currentMovieListSubject.asObservable();

    this.moviesInCurrentListSubject = new BehaviorSubject<Movie[]>([]);
    this.moviesInCurrentList$ = this.moviesInCurrentListSubject.asObservable();
  }

  // Get all movie lists
  getMovieLists() {
    return this.http.get<MovieList[]>(this.movieListUrl).pipe(
      tap(data => this.saveLists(data)),
      shareReplay()
    );
  }

  saveLists(data) {
    data.reverse(); // Place recently added first
    this.movieListsSubject.next(data);
  }

  getMoviesOnListBySlug(slug) {
    const url = this.movieListUrl + slug + "/movies";
    return this.http.get<Movie[]>(url).pipe(
      tap(data => this.saveMoviesInCurrentList(data)),
      shareReplay()
    );
  }

  saveMoviesInCurrentList(data) {
    this.moviesInCurrentListSubject.next(data);
  }

  searchForMovieList(slug) {
    if (this.movieListsSubject.value) {
      return this.movieListsSubject.value.find(
        _movieList => _movieList.slug === slug
      );
    }
    return null;
  }

  getMovieList(slug) {
    return this.http.get<MovieList>(this.movieListUrl + slug).pipe(
      tap(data => this.saveCurrentList(data)),
      shareReplay()
    );
  }

  saveCurrentList(data) {
    this.currentMovieListSubject.next(data);
  }

  addMovieList(data) {
    return this.http.post<MovieList>(this.movieListUrl, data).pipe(
      tap(data => this.updateMovieList(data)),
      map((data: MovieList) => data.slug),

      shareReplay()
    );
  }

  updateMovieList(data) {
    this.movieListsSubject.next([data, ...this.movieListsSubject.value]);
  }

  addMovieToList(movie: Movie) {
    const currentMovies = this.moviesInCurrentListSubject.value;

    if (currentMovies === null) {
      // This case, in general. Should not happen.
      this.moviesInCurrentListSubject.next([movie]);
    } else {
      this.moviesInCurrentListSubject.next([movie, ...currentMovies]);
    }
  }

  addDefaultImage(movieListId: number, defaultImageUrl: string) {
    this.http
      .put<MovieList>(this.movieListUrl + movieListId, {
        defaultImageUrl
      })
      .subscribe(data => this.updateMovieInList(data));
  }

  updateMovieInList(movieList: MovieList) {
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

  deleteMovieList() {}
}
