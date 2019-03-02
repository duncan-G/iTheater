import { Component, OnInit, ViewEncapsulation, OnDestroy } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { MatDialog, MatDialogRef } from "@angular/material";

import { AddNewMovieComponent } from "./add-new-movie/add-new-movie.component";
import { Movie } from "src/app/core/models/movie.interface";
import { MovieList } from "src/app/core/models/movie-list.interface";
import { MovieListsService } from "src/app/core/services/movie-lists.service";
import { Subscription } from 'rxjs';

@Component({
  selector: "app-movie-list",
  templateUrl: "./movie-list.component.html",
  styleUrls: ["./movie-list.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListComponent implements OnInit, OnDestroy {
  private dialogRef: MatDialogRef<AddNewMovieComponent>;
  private movieList: MovieList;
  private movieListSubscription: Subscription;
  private moviesSubscription: Subscription;

  public movies: Movie[] = [];
  public loadingList = true;
  public loadingMovies = true;

  constructor(
    private router: ActivatedRoute,
    private dialog: MatDialog,
    private movieListService: MovieListsService
  ) {
    this.movieListSubscription = this.movieListService.moviesInCurrentList$.subscribe(
      data => {
        (this.movies = data)
      }
    );
    this.moviesSubscription = this.movieListService.currentMovieList$.subscribe(
      data => (this.movieList = data)
    );
  }

  ngOnInit() {
    this.router.params.subscribe(({ listSlug }) => {
      this.getMovieList(listSlug);
      this.getMovies(listSlug);
    });
  }

  openDialog() {
    this.dialogRef = this.dialog.open(AddNewMovieComponent, {
      width: "70%",
      maxWidth: "900px",
      height: "60%",
      maxHeight: "800px"
    });
  }

  getMovies(slug) {
    this.movieListService
      .getMoviesOnListBySlug(slug)
      .subscribe(
        () => (this.loadingMovies = false),
        error => console.error(error)
      );
  }

  getMovieList(slug) {
    this.movieListService.getMovieList(slug).subscribe(
      () => (this.loadingList = false),
      error => console.error(error)
    );
  }

  ngOnDestroy() {
    this.movieListSubscription.unsubscribe();
    this.moviesSubscription.unsubscribe();
  }
}
