import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { movieListWithImage } from "../../fake-db/movie-lists";

@Component({
  selector: "app-movie-lists",
  templateUrl: "./movie-lists.component.html",
  styleUrls: ["./movie-lists.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieListsComponent implements OnInit {
  public movieLists: any[];

  constructor() {
    this.movieLists = movieListWithImage;
  }

  ngOnInit() {}
}
