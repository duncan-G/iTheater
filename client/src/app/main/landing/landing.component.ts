import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { popularMovies } from "../../fake-db/popular-movies";
import { MoviesService } from "src/app/core/services/movies.service";
import { Router } from "@angular/router";
import { AuthService } from "src/app/core/services/auth.service";

@Component({
  selector: "app-landing",
  templateUrl: "./landing.component.html",
  styleUrls: ["./landing.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class LandingComponent implements OnInit {
  public popularMovies: any;
  public imageBaseUrl = "http://image.tmdb.org/t/p/original/";
  public userLoggedIn = false;

  constructor(
    private router: Router,
    private movieService: MoviesService,
    private authService: AuthService
  ) {
    this.popularMovies = popularMovies.results;
    this.movieService.popularMovies$.subscribe(
      data => (this.popularMovies = data.slice(0, 8)) // limit to 8 for now
    );

    this.authService.currentUser$.subscribe(user => {
      this.userLoggedIn = this.authService.isLoggedIn();
    });
  }

  ngOnInit() {
    const page = 1; // fetch first page
    this.movieService.getPopularMovies(page);
  }

  handleSuccess() {}

  formatBgImg(imgUrl) {
    return `url("${this.imageBaseUrl + imgUrl}"`;
  }

  handleSignUp() {
    this.router.navigateByUrl("/register");
  }
}
