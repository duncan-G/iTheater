import { Component, OnInit, ViewEncapsulation, Input } from "@angular/core";
import { environment } from "src/environments/environment";

@Component({
  selector: "app-movie-item",
  templateUrl: "./movie-item.component.html",
  styleUrls: ["./movie-item.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieItemComponent implements OnInit {
  @Input() movie: any;
  @Input() listName: string;
  public posterPathBase = "http://image.tmdb.org/t/p/w300/";

  constructor() {}

  ngOnInit() {}

  getPosterUrl(posterPath) {
    return posterPath
      ? this.posterPathBase + posterPath
      : environment.defaultPosterUrl;
  }
}
