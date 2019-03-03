import { NgModule } from "@angular/core";
import { CardListComponent } from "./card-list.component";
import { CardListItemComponent } from "./card-list-item/card-list-item.component";
import {
  MatTooltipModule,
  MatButtonModule,
  MatIconModule
} from "@angular/material";
import { CommonModule } from "@angular/common";
import { BarRatingModule } from "ngx-bar-rating";
import { RouterModule } from "@angular/router";

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    BarRatingModule,
    MatButtonModule,
    MatIconModule,
    MatTooltipModule
  ],
  declarations: [CardListComponent, CardListItemComponent],
  exports: [CardListComponent, CardListItemComponent]
})
export class CardListModule {}
