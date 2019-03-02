import {
  Component,
  OnInit,
  Input,
  ViewEncapsulation,
  OnDestroy
} from "@angular/core";
import { environment } from "src/environments/environment";
import { MoviesService } from "src/app/core/services/movies.service";
import { MovieListsService } from "src/app/core/services/movie-lists.service";
import { MovieList } from "src/app/core/models/movie-list.interface";
import { Subscription } from "rxjs";

@Component({
  selector: "app-movie-search-results",
  templateUrl: "./movie-search-results.component.html",
  styleUrls: ["./movie-search-results.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class MovieSearchResultsComponent implements OnInit, OnDestroy {
  @Input() movies: any[];
  private movieList: MovieList;
  private movieListSubscription: Subscription;
  public posterImageBaseUrl = environment.posterSmallBaseUrl;

  constructor(
    private movieService: MoviesService,
    private movieListsService: MovieListsService
  ) {
    this.movieListSubscription = this.movieListsService.currentMovieList$.subscribe(
      data => (this.movieList = data)
    );
  }

  ngOnInit() {}

  handleAddMovie(movie) {
    if (!this.movieList) {
      //Something went really wrong
      this.handleError();
    } else {
      movie.movieListId = this.movieList.id;
      this.movieService
        .addMovieToList(movie)
        .subscribe(() => this.handleSuccess(), error => this.handleError());
    }
  }

  handleSuccess() {
    console.log("working");
  }

  handleError() {}

  ngOnDestroy() {
    this.movieListSubscription.unsubscribe();
  }
}
