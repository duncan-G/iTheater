import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { SharedModule } from "src/app/shared/shared.module";
import { MovieListsComponent } from "./movie-lists.component";
import {
  MatButtonModule,
  MatIconModule,
  MatTooltipModule,
  MatFormFieldModule,
  MatInputModule,
  MatDialogModule,
  MatCheckboxModule
} from "@angular/material";
import { MovieListFormComponent } from "./movie-list-form/movie-list-form.component";
import { CardListModule } from 'src/app/shared/card-list/card-list.module';

const routes: Routes = [
  {
    path: "my-theater",
    component: MovieListsComponent
  }
];
@NgModule({
  declarations: [
    MovieListsComponent,
    MovieListFormComponent
  ],
  imports: [
    RouterModule.forChild(routes),
    CardListModule,
    MatButtonModule,
    MatCheckboxModule,
    MatDialogModule,
    MatIconModule,
    MatTooltipModule,
    MatFormFieldModule,
    MatInputModule,
    SharedModule
  ],
  entryComponents: [MovieListFormComponent]
})
export class MovieListsModule {}
