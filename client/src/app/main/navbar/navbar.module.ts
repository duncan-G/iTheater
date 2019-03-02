import { NgModule } from "@angular/core";
import { NavbarComponent } from "./navbar.component";
import {
  MatToolbarModule,
  MatButtonModule,
  MatDividerModule,
  MatIconModule
} from "@angular/material";
import { SharedModule } from "src/app/shared/shared.module";
import { RouterModule } from "@angular/router";

@NgModule({
  declarations: [NavbarComponent],
  imports: [
    SharedModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatDividerModule,
    RouterModule
  ],
  exports: [NavbarComponent]
})
export class NavbarModule {}
