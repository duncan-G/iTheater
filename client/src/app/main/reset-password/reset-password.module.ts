import { NgModule } from "@angular/core";
import { ResetPasswordComponent } from "./reset-password.component";
import { RouterModule } from "@angular/router";

const routes = [
  {
    path: "reset-password",
    component: ResetPasswordComponent
  }
];
@NgModule({
  declarations: [ResetPasswordComponent],
  imports: [RouterModule.forChild(routes)]
})
export class ResetPasswordModule {}
