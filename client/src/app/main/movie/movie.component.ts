import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { movie } from "src/app/fake-db/movie";
import { EmbedVideoService } from "ngx-embed-video";

@Component({
  selector: "app-movie",
  templateUrl: "./movie.component.html",
  styleUrls: ["./movie.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieComponent implements OnInit {
  public movie: any;
  public videoIframe: any;
  public imageBaseUrl = "http://image.tmdb.org/t/p/original/";
  public rating = 0;

  constructor(private embedService: EmbedVideoService) {
    this.movie = movie;
  }

  ngOnInit() {
    const videoUrl =
      "https://www.youtube.com/watch?v=" + movie.videos.results[0].key;

    this.videoIframe = this.embedService.embed(videoUrl);
    console.log(this.videoIframe);
  }
}
