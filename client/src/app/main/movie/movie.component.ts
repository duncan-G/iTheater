import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { EmbedVideoService } from "ngx-embed-video";
import { ActivatedRoute } from "@angular/router";
import { MoviesService } from "src/app/core/services/movies.service";

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
  public loading = true;

  constructor(
    private activatedRoute: ActivatedRoute,
    private movieService: MoviesService,
    private embedService: EmbedVideoService
  ) {
  }

  ngOnInit() {
    this.activatedRoute.params.subscribe(({ movieId }) => {
      this.movieService
        .getMovieById(movieId)
        .subscribe(
          movie => this.loadMovie(movie),
          error => this.handleError(error)
        );
    });
  }

  loadMovie(movie: any) {
    this.movie = movie;
    console.log(movie);

    let ytVideo;
    if (movie.videos && Array.isArray(movie.videos.results)) {
      ytVideo = movie.videos.results.find(video => video.site === "YouTube");
    }

    if (ytVideo) {
      this.loadTrailer(ytVideo);
    }
  }

  loadTrailer(ytVideo) {
    const videoUrl = "https://www.youtube.com/watch?v=" + ytVideo.key;
    this.videoIframe = this.embedService.embed(videoUrl);
  }

  handleSuccess() {}

  handleError(error) {
    console.log(error);
  }
}
