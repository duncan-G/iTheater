import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-movie-list-item',
  templateUrl: './movie-list-item.component.html',
  styleUrls: ['./movie-list-item.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class MovieListItemComponent implements OnInit {

  @Input() list: any;
  public imageBaseUrl = 'http://image.tmdb.org/t/p/w300/';

  constructor() { }

  ngOnInit() {
  }

  getDefaultImageUrl(defaultImagePath) {
    return defaultImagePath
      ? this.imageBaseUrl + defaultImagePath
      : environment.defaultPosterUrl;
  }

}
