import { NgModule } from "@angular/core";
import { LandingComponent } from "./landing.component";
import { RouterModule } from "@angular/router";
import { SharedModule } from "src/app/shared/shared.module";
import { MatButtonModule, MatIconModule } from "@angular/material";

const routes = [
  {
    path: "",
    component: LandingComponent
  }
];
@NgModule({
  declarations: [LandingComponent],
  imports: [RouterModule.forChild(routes), MatButtonModule, MatIconModule, SharedModule]
})
export class LandingModule {}
