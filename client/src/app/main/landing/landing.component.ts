import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { popularMovies } from "../../fake-db/popular-movies";

@Component({
  selector: "app-landing",
  templateUrl: "./landing.component.html",
  styleUrls: ["./landing.component.scss"],
  encapsulation: ViewEncapsulation.None
})

export class LandingComponent implements OnInit {
  public popularMovies: any;
  public imageBaseUrl = "http://image.tmdb.org/t/p/original/";

  constructor() {
    this.popularMovies = popularMovies.results;
  }

  ngOnInit() {}

  formatBgImg(imgUrl) {
    return `url("${this.imageBaseUrl + imgUrl}"`;
  }
}
