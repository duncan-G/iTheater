import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { Page500Component } from './page500.component';

const routes = [
  {
    path: "error-500",
    component: Page500Component
  }
];
@NgModule({
  declarations: [Page500Component],
  imports: [RouterModule.forChild(routes)]
})
export class Page500Module {}
