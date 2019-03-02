import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-movie-search-results',
  templateUrl: './movie-search-results.component.html',
  styleUrls: ['./movie-search-results.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class MovieSearchResultsComponent implements OnInit {

  @Input() movies : any[];

  public posterImageBaseUrl = environment.posterSmallBaseUrl;

  constructor() { }

  ngOnInit() {
  }

  handleAddMovie(movie) {
    console.log(movie);
  }

}
