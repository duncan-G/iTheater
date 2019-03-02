import { NgModule } from "@angular/core";
import { MovieListComponent } from "./movie-list.component";
import { RouterModule } from "@angular/router";
import { BarRatingModule } from "ngx-bar-rating";
import { MovieItemComponent } from "./movie-item/movie-item.component";
import { SharedModule } from "src/app/shared/shared.module";
import {
  MatTooltipModule,
  MatButtonModule,
  MatIconModule,
  MatDialogModule,
  MatDividerModule,
  MatFormFieldModule,
  MatInputModule
} from "@angular/material";
import { AddNewMovieComponent } from "./add-new-movie/add-new-movie.component";
import { MovieSearchResultsComponent } from './movie-search-results/movie-search-results.component';

const routes = [
  {
    path: "my-theater/:listName",
    component: MovieListComponent
  }
];
@NgModule({
  declarations: [MovieListComponent, MovieItemComponent, AddNewMovieComponent, MovieSearchResultsComponent],
  imports: [
    RouterModule.forChild(routes),
    MatDialogModule,
    MatTooltipModule,
    MatButtonModule,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
    MatDividerModule,
    BarRatingModule,
    SharedModule
  ],
  entryComponents: [AddNewMovieComponent]
})
export class MovieListModule {}
