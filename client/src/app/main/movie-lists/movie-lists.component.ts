import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { MovieListsService } from "src/app/core/services/movie-lists.service";
import { IMovieList } from "src/app/core/models/movie-list.interface";
import { MatDialog, MatDialogRef } from "@angular/material";
import { environment } from "src/environments/environment";
import { MovieListFormComponent, IMovieListFormDialogData } from "./movie-list-form/movie-list-form.component";

@Component({
  selector: "app-movie-lists",
  templateUrl: "./movie-lists.component.html",
  styleUrls: ["./movie-lists.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListsComponent implements OnInit {
  public movieLists: IMovieList[];

  constructor(
    private movieListService: MovieListsService,
    private dialog: MatDialog
  ) {
    // Ensure methods have the correct this context when called in child components
    this.openEditDialog = this.openEditDialog.bind(this);
  }

  ngOnInit() {
    this.movieListService.getMovieLists().subscribe(() => {
      this.movieListService.movieLists$.subscribe(
        data => (this.movieLists = data)
      );
    });
  }

  openAddDialog() {
    this.dialog.open(MovieListFormComponent, {
      data: {
        dialogTitle: "Add New Movie List",
        submitText: "ADD NEW LIST",
        formType: "add"
      } as IMovieListFormDialogData,
      width: "50%",
      maxWidth: "600px",
    });
  }

  openEditDialog(movieList: IMovieList) {
    this.dialog.open(MovieListFormComponent, {
      data: {
        dialogTitle: "Edit New " + movieList.name,
        submitText: "EDIT LIST",
        formType: "edit",
        name: movieList.name,
        privacy: movieList.privacy,
        movieListId: movieList.id

      },
      width: "50%",
      maxWidth: "600px"
    });
  }

  getDefaultImageUrl(movieList: IMovieList) {
    const posterPathBase = "http://image.tmdb.org/t/p/w300/";

    return movieList.defaultImageUrl
      ? posterPathBase + movieList.defaultImageUrl
      : environment.defaultPosterUrl;
  }

  getOnClickPath(movieList: IMovieList) {
    return `/my-theater/${movieList.slug}`;
  }
}
