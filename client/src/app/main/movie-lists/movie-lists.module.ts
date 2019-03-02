import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { SharedModule } from "src/app/shared/shared.module";
import { MovieListsComponent } from "./movie-lists.component";
import { MovieListItemComponent } from "./movie-list-item/movie-list-item.component";
import {
  MatButtonModule,
  MatIconModule,
  MatTooltipModule,
  MatFormFieldModule,
  MatInputModule,
  MatDialogModule,
  MatCheckboxModule
} from "@angular/material";
import { AddNewListComponent } from "./add-new-list/add-new-list.component";

const routes: Routes = [
  {
    path: "my-theater",
    component: MovieListsComponent
  }
];
@NgModule({
  declarations: [
    MovieListsComponent,
    MovieListItemComponent,
    AddNewListComponent
  ],
  imports: [
    RouterModule.forChild(routes),
    MatButtonModule,
    MatCheckboxModule,
    MatDialogModule,
    MatIconModule,
    MatTooltipModule,
    MatFormFieldModule,
    MatInputModule,
    SharedModule
  ],
  entryComponents: [AddNewListComponent]
})
export class MovieListsModule {}
