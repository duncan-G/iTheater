import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { BarRatingModule } from "ngx-bar-rating";
import { SharedModule } from "src/app/shared/shared.module";
import { MovieComponent } from "./movie.component";

const routes = [
  {
    path: "my-theater/:listName/:movieId",
    component: MovieComponent
  }
];
@NgModule({
  declarations: [MovieComponent],
  imports: [
    RouterModule.forChild(routes),
    BarRatingModule,
    SharedModule
  ]
})
export class MovieModule {}
