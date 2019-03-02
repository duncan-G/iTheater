import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BehaviorSubject, Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { tap, shareReplay } from "rxjs/operators";
import { MovieList } from "../models/movie-list.interface";

@Injectable()
export class MovieListsService {
  private movieListsSubject: BehaviorSubject<MovieList[]>;
  public movieLists: Observable<MovieList[]>;
  private movieListUrl: string;

  constructor(private http: HttpClient) {
    this.movieListUrl = environment.serverUrl + "api/movielists";
    this.movieListsSubject = new BehaviorSubject<MovieList[]>(null);
    this.movieLists = this.movieListsSubject.asObservable();
  }

  fetchData() {
    return this.http.get<MovieList[]>(this.movieListUrl).pipe(
      tap(data => this.saveData(data)),
      shareReplay()
    );
  }

  saveData(data) {
    data.reverse(); // Place recently added first
    this.movieListsSubject.next(data);
  }

  addMovieList(data) {
    data.defaultImageUrl = environment.defaultPosterUrl;
    return this.http.post<MovieList>(this.movieListUrl, data).pipe(
      tap(data => this.updateMovieList(data)),
      shareReplay()
    );
  }

  updateMovieList(data) {
    this.movieListsSubject.next([data, ...this.movieListsSubject.value]);
  }

  deleteMovieList() {}
}
