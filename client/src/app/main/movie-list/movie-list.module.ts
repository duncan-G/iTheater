import { NgModule } from "@angular/core";
import { MovieListComponent } from "./movie-list.component";
import { RouterModule } from "@angular/router";

const routes = [
  {
    path: "my-theater/:movie-list",
    component: MovieListComponent
  }
];
@NgModule({
  declarations: [MovieListComponent],
  imports: [RouterModule.forChild(routes)]
})
export class MovieListModule {} 
