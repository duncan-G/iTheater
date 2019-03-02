import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { BehaviorSubject, Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { tap, map, shareReplay } from "rxjs/operators";
import { MovieList } from "../models/movie-list.interface";
import { Movie } from "../models/movie.interface";

@Injectable()
export class MoviesService {
  private moviesSubject: BehaviorSubject<MovieList[]>;
  private moviesUrl = environment.serverUrl + "api/movies";
  private movieDbBaseUrl = environment.movieBaseUrl;
  private movideDbKey = environment.moviePublicKey;

  public movies: Observable<MovieList[]>;

  constructor(private http: HttpClient) {
    this.moviesSubject = new BehaviorSubject<MovieList[]>([]);
    this.movies = this.moviesSubject.asObservable();
  }

  search(query) {
    const searchUrl = `${this.movieDbBaseUrl}search/movie?api_key=${
      this.movideDbKey
    }&query=${query}`;

    return this.http.get<any>(searchUrl, { observe: "response" }).pipe(
      tap(response => this.updateRateLimits(response.headers)),
      map(response => this.mapResults(response.body.results)),
      shareReplay()
    );
  }

  updateRateLimits(headers) {
    const limit = headers.get("X-RateLimit-Limit");
    const remaining = headers.get("X-RateLimit-Remaining");
    const resetTime = headers.get("X-RateLimit-Reset");
    console.log(limit, remaining, resetTime);
  }

  mapResults(results): Movie[] {
    const relevantKeys = [
      "id",
      "title",
      "poster_path",
      "overview",
      "release_date"
    ];
    return results.map(movieResult => {
      return relevantKeys.reduce(
        (movie, key) => ({
          ...movie,
          [key]: movieResult[key]
        }),
        {}
      ) as Movie;
    });
  }

  getMovieById() {}

  getMovies() {}

  addMovieToList(list: string) {}

  updateMovie(id: number, rating: number) {}

  deleteMovie(id: number) {}
}
