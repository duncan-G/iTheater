import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { movieListsWithMovies } from "src/app/fake-db/movie-lists";
import { MatDialog, MatDialogRef } from "@angular/material";

import { AddNewMovieComponent } from "./add-new-movie/add-new-movie.component";

@Component({
  selector: "app-movie-list",
  templateUrl: "./movie-list.component.html",
  styleUrls: ["./movie-list.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListComponent implements OnInit {
  private moviesList: any;
  public movies: any[];
  public listName: string;
  private dialogRef: MatDialogRef<AddNewMovieComponent>;

  constructor(private router: ActivatedRoute, private dialog: MatDialog) {
    this.moviesList = movieListsWithMovies;
  }

  ngOnInit() {
    this.router.params.subscribe(({ listName }) => {
      this.listName = listName;
      this.movies = this.moviesList[listName];
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
}
