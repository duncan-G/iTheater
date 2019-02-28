import { NgModule } from "@angular/core";
import { NavbarComponent } from "./navbar.component";
import { MatToolbarModule, MatButtonModule, MatDividerModule } from '@angular/material';
import { SharedModule } from 'src/app/shared/shared.modules';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [NavbarComponent],
  imports: [
    SharedModule,
    MatToolbarModule,
    MatButtonModule,
    MatDividerModule,
    RouterModule
  ],
  exports: [
    NavbarComponent
  ]
})
export class NavbarModule {}
