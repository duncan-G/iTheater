import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import * as moment from "moment";
import { environment } from "src/environments/environment";
import { tap, map, delay, shareReplay } from "rxjs/operators";
import { IMovie, IPopularMovie } from "../models/movie.interface";
import { isComponentView } from "@angular/core/src/view/util";

@Injectable()
export class MoviesDbService {
  private movieDbBaseUrl = environment.movieBaseUrl;
  private movideDbKey = environment.moviePublicKey;

  private remaining: number;
  private resetTime: number;

  constructor(private http: HttpClient) {}

  search(query: string) {
    const searchUrl = `${this.movieDbBaseUrl}search/movie?api_key=${
      this.movideDbKey
    }&query=${query}`;

    return this.makeGetAllRequest(searchUrl);
  }

  getPopular(page: number) {
    const popularUrl = `${this.movieDbBaseUrl}movie/popular?api_key=${
      this.movideDbKey
    }&language=en-US&page=${page}`;

    return this.makeGetAllRequest(popularUrl, true);
  }

  getSingleMovie(movieDbId: number) {
    const movieUrl = `${this.movieDbBaseUrl}movie/${movieDbId}?api_key=${
      this.movideDbKey
    }&language=en-US&append_to_response=videos`;

    const headers = new HttpHeaders();
    headers.append("Content-Type", "application/json");
    headers.append("Accept", "application/json");

    const delayTime = this.calculateDelayTime();
    return this.http.get<any>(movieUrl, { headers }).pipe(
      delay(delayTime),
      shareReplay()
    );
  }

  private makeGetAllRequest(url: string, isPopular = false) {
    const delayTime = this.calculateDelayTime();
    return this.http.get<any>(url, { observe: "response" }).pipe(
      delay(delayTime),
      tap(response => this.updateRateLimits(response.headers)),
      map(response => this.mapResults(response.body.results, isPopular)),
      shareReplay()
    );
  }

  private calculateDelayTime() {
    if (this.remaining === undefined || this.remaining > 0) {
      return 0;
    }

    const timeRemaining = this.resetTime - Math.floor(Date.now() / 1000);
    return Math.max(0, timeRemaining);
  }
  private updateRateLimits(headers: HttpHeaders) {
    this.remaining = +headers.get("X-RateLimit-Remaining");
    this.resetTime = +headers.get("X-RateLimit-Reset");
  }

  private mapResults(results: any[], isPopular: boolean) {
    return results.map(movieResult => {
      return isPopular
        ? this.formatPopularMovie(movieResult)
        : this.formatMovie(movieResult);
    });
  }

  private formatPopularMovie(movieResult) {
    const relevantKeys = [
      "backdrop_path",
      "overview",
      "vote_average",
      "vote_count",
      "title"
    ];
    return relevantKeys.reduce(
      (movie, key) => ({
        ...movie,
        [this.formatKey(key)]: movieResult[key]
      }),
      {}
    ) as IPopularMovie;
  }

  formatMovie(movieResult) {
    const relevantKeys = ["id", "title", "poster_path", "release_date"];
    return relevantKeys.reduce(
      (movie, key) => ({
        ...movie,
        [this.formatKey(key)]: movieResult[key]
      }),
      {}
    ) as IPopularMovie;
  }

  private formatKey(key: string) {
    switch (key) {
      case "poster_path":
        return "posterPath";
      case "release_data":
        return "releaseDate";
      case "id":
        return "moviesDbId";
      case "backdrop_path":
        return "backdropPath";
      case "vote_average":
        return "voteAverage";
      case "vote_count":
        return "voteCount";
      default:
        return key;
    }
  }
}
