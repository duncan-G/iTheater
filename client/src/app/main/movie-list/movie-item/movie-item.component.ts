import { Component, OnInit, ViewEncapsulation, Input } from "@angular/core";

@Component({
  selector: "app-movie-item",
  templateUrl: "./movie-item.component.html",
  styleUrls: ["./movie-item.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieItemComponent implements OnInit {
  @Input() movie: any;
  @Input() listName: string;
  public imageBaseUrl = "http://image.tmdb.org/t/p/w300/";

  constructor() {}

  ngOnInit() {
  }
}
