import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { movieListWithImage } from "../../fake-db/movie-lists";
import { MovieListsService } from "src/app/core/services/movie-lists.service";
import { MovieList } from "src/app/core/models/movie-list.interface";
import { MatDialog, MatDialogRef } from "@angular/material";

import { AddNewListComponent } from "./add-new-list/add-new-list.component";

@Component({
  selector: "app-movie-lists",
  templateUrl: "./movie-lists.component.html",
  styleUrls: ["./movie-lists.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListsComponent implements OnInit {
  public movieLists: MovieList[];
  private dialogRef : MatDialogRef<AddNewListComponent>;

  constructor(
    private movieListService: MovieListsService,
    private dialog: MatDialog
  ) {}

  ngOnInit() {
    this.movieListService.fetchData().subscribe(() => {
      this.movieListService.movieLists.subscribe(
        data => (this.movieLists = data)
      );
    });
  }

  openDialog() {
    this.dialogRef = this.dialog.open(AddNewListComponent);
  }

  ngOnDestroy(){
    this.dialogRef && this.dialogRef.close();
  }
}
