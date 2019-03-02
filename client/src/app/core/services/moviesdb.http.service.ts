import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import * as moment from "moment";
import { environment } from "src/environments/environment";
import { tap, map, delay, shareReplay } from "rxjs/operators";
import { IMovie } from "../models/movie.interface";

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

    return this.makeGetRequest(searchUrl);
  }

  getPopular(page: number) {
    const popularUrl = `${this.movieDbBaseUrl}movie/popular?api_key=${
      this.movideDbKey
    }&language=en-US&page=${page}`;

    return this.makeGetRequest(popularUrl);
  }

  getMovie(movieDbId: number) {
    const movieUrl = `${this.movieDbBaseUrl}movie/${movieDbId}?api_key=${
      this.movideDbKey
    }&append_to_response=videos`;
    
    return this.makeGetRequest(movieUrl);
  }

  private makeGetRequest(url: string) {
    const delayTime = this.calculateDelayTime();
    return this.http.get<any>(url, { observe: "response" }).pipe(
      delay(delayTime),
      tap(response => this.updateRateLimits(response.headers)),
      map(response => this.mapResults(response.body.results)),
      shareReplay()
    );
  }

  private calculateDelayTime() {
    if (!this.remaining) {
      return 0;
    }
    const resetTime = moment().add(this.resetTime, "second");
    return moment().diff(resetTime);
  }
  private updateRateLimits(headers: HttpHeaders) {
    this.remaining = +headers.get("X-RateLimit-Remaining");
    this.resetTime = +headers.get("X-RateLimit-Reset");
  }

  private mapResults(results: any[]): IMovie[] {
    const relevantKeys = ["id", "title", "poster_path", "release_date"];

    return results.map(movieResult => {
      return relevantKeys.reduce(
        (movie, key) => ({
          ...movie,
          [this.formatKey(key)]: movieResult[key]
        }),
        {}
      ) as IMovie;
    });
  }

  private formatKey(key: string) {
    switch (key) {
      case "poster_path":
        return "posterPath";
      case "release_data":
        return "releaseDate";
      case "id":
        return "moviesDbId";
      default:
        return key;
    }
  }
}
