import { NgModule } from '@angular/core';
import { MovieListsComponent } from './movie-lists.component';
import { RouterModule, Routes } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.modules';

const routes: Routes = [
    {
      path: "my-theater",
      component: MovieListsComponent
    }
  ];
@NgModule({
    declarations: [MovieListsComponent],
    imports: [
        RouterModule.forChild(routes),
        SharedModule
    ]
})
export class MovieListsModule {}