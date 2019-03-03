import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { IMovieList, IUpdateMovieList, ICreateMovieList } from "../models/movie-list.interface";
import { IMovie, IUpdateMovie, ICreateMovie } from "../models/movie.interface";

@Injectable()
export class ItheaterHttpService {
  private movieListUrl = environment.serverUrl + "api/movielists/";
  private moviesUrl = environment.serverUrl + "api/movies/";

  constructor(private http: HttpClient) {}

  /**
   * Movie Lists
   */
  getMovieLists() {
    return this.http.get<IMovieList[]>(this.movieListUrl);
  }

  getMovieListBySLug(slug: string) {
    return this.http.get<IMovieList>(this.movieListUrl + slug);
  }

  getMoviesOnListBySlug(slug: string) {
    const url = this.movieListUrl + slug + "/movies";
    return this.http.get<IMovie[]>(url);
  }

  createMovieList(movieList: ICreateMovieList) {
    return this.http.post<IMovieList>(this.movieListUrl, movieList);
  }

  updateMovieList(movieListId: number, movieList: IUpdateMovieList) {
    return this.http.put<IMovieList>(this.movieListUrl + movieListId, movieList);
  }

  deleteMovieList(movieListId: number) {
    return this.http.delete<void>(this.movieListUrl + movieListId);
  }

  /**
   * Movie
   */

  addMovieToList(movie: ICreateMovie) {
    return this.http.post<IMovie>(this.moviesUrl, movie);
  }

  updateMovie(movieId: number, movie: IUpdateMovie) {
    return this.http.put<IMovie>(this.moviesUrl + movieId, movie);
  }

  deleteMovie(movieId: number) {
    return this.http.delete<void>(this.moviesUrl + movieId);
  }
}
