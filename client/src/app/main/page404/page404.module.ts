import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { Page404Component } from './page404.component';

const routes = [
  {
    path: "error-404",
    component: Page404Component
  }
];
@NgModule({
  declarations: [Page404Component],
  imports: [RouterModule.forChild(routes)]
})
export class Page404Module {}
