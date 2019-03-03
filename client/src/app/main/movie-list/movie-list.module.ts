import { NgModule } from "@angular/core";
import { MovieListComponent } from "./movie-list.component";
import { RouterModule } from "@angular/router";
import { BarRatingModule } from "ngx-bar-rating";
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
import { MovieSearchResultsComponent } from "./movie-search-results/movie-search-results.component";
import { CardListModule } from "src/app/shared/card-list/card-list.module";
import { DeleteListConfirmationComponent } from "./delete-list-confirmation/delete-list-confirmation.component";

const routes = [
  {
    path: "my-theater/:listSlug",
    component: MovieListComponent
  }
];
@NgModule({
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
    CardListModule,
    SharedModule
  ],
  declarations: [
    MovieListComponent,
    AddNewMovieComponent,
    MovieSearchResultsComponent,
    DeleteListConfirmationComponent
  ],

  entryComponents: [AddNewMovieComponent, DeleteListConfirmationComponent]
})
export class MovieListModule {}
