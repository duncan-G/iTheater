import { Component, OnInit, ViewEncapsulation, OnDestroy } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { MatDialog, MatDialogRef } from "@angular/material";
import { Subscription } from "rxjs";

import { AddNewMovieComponent } from "./add-new-movie/add-new-movie.component";
import { IMovie } from "src/app/core/models/movie.interface";
import { IMovieList } from "src/app/core/models/movie-list.interface";
import { MovieListsService } from "src/app/core/services/movie-lists.service";
import { environment } from "src/environments/environment";
import { MoviesService } from "src/app/core/services/movies.service";
import { movie } from "src/app/fake-db/movie";
import { DeleteConfirmationDialogComponent } from 'src/app/shared/delete-confirmation-dialog/delete-confirmation-dialog.component';

@Component({
  selector: "app-movie-list",
  templateUrl: "./movie-list.component.html",
  styleUrls: ["./movie-list.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListComponent implements OnInit, OnDestroy {
  private dialogRef: MatDialogRef<AddNewMovieComponent>;
  private movieListSubscription: Subscription;
  private moviesSubscription: Subscription;

  public movieList: IMovieList;
  public movies: IMovie[] = [];
  public loadingList = true;
  public loadingMovies = true;
  public testList = {};

  constructor(
    private router: Router,
    private activatedRoute: ActivatedRoute,
    private dialog: MatDialog,
    private movieService: MoviesService,
    private movieListService: MovieListsService
  ) {
    this.movieListSubscription = this.movieListService.moviesInCurrentList$.subscribe(
      data => {
        this.movies = data;
      }
    );
    this.moviesSubscription = this.movieListService.currentMovieList$.subscribe(
      data => {
        this.movieList = data;
      }
    );

    // Ensure methods have the right this context when executed in child components
    this.getOnClickPath = this.getOnClickPath.bind(this);
    this.deleteMovieFromList = this.deleteMovieFromList.bind(this);
    this.updateMovieRating = this.updateMovieRating.bind(this);
  }

  ngOnInit() {
    this.activatedRoute.params.subscribe(({ listSlug }) => {
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

  getMovies(slug: string) {
    this.movieListService
      .getMoviesOnListBySlug(slug)
      .subscribe(
        () => (this.loadingMovies = false),
        error => console.error(error)
      );
  }

  getMovieList(slug: string) {
    const movieList = this.movieListService.searchForMovieList(slug); // Do refetch data if it exists
    if (movieList) {
      this.movieListService.saveCurrentList(movieList);
    } else {
      this.movieListService
        .getMovieList(slug)
        .subscribe(
          () => (this.loadingList = false),
          error => console.error(error)
        );
    }
  }

  handleDeleteMovieList() {
    const deleteDialog = this.dialog.open(DeleteConfirmationDialogComponent, {
      data: {
        name: this.movieList.name
      },
      width: "50%",
      maxWidth: "600px"
    });

    deleteDialog.afterClosed().subscribe(deleteList => {
      if (deleteList) {
        this.deleteMovieList();
      }
    });
  }

  deleteMovieList() {
    this.movieListService
      .deleteMovieList(this.movieList.id)
      .subscribe(
        () => this.router.navigateByUrl("/my-theater"),
        error => console.error(error)
      );
  }

  deleteMovieFromList(movieId: number) {
    this.movieService
      .deleteMovie(movieId)
      .subscribe(() => this.handleSuccess(), error => this.handleError(error));
  }

  updateMovieRating(rating, movie: IMovie) {
    this.movieService
      .updateMovie(movie.id, {
        rating: rating
      })
      .subscribe(() => this.handleSuccess(), error => this.handleError(error));
  }

  getImageUrl(movie: IMovie) {
    const posterPathBase = "http://image.tmdb.org/t/p/w300/";

    return movie.posterPath
      ? posterPathBase + movie.posterPath
      : environment.defaultPosterUrl;
  }

  getOnClickPath(movie: IMovie) {
    return `/my-theater/${this.movieList.slug}/${movie.moviesDbId}`;
  }

  private handleSuccess() {}

  private handleError(error) {
    console.error(error);
  }

  ngOnDestroy() {
    this.movieListSubscription.unsubscribe();
    this.moviesSubscription.unsubscribe();
  }
}
