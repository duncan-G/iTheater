import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NguCarouselModule  } from '@ngu/carousel';
import { SharedModule } from 'src/app/shared/shared.modules';
import { MovieListsComponent } from './movie-lists.component';
import { MovieListItemComponent } from './movie-list-item/movie-list-item.component';

const routes: Routes = [
    {
      path: "my-theater",
      component: MovieListsComponent
    }
  ];
@NgModule({
    declarations: [MovieListsComponent, MovieListItemComponent],
    imports: [
        RouterModule.forChild(routes),
        NguCarouselModule,
        SharedModule
    ],
})
export class MovieListsModule {}