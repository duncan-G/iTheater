import { NgModule } from "@angular/core";
import { LoginComponent } from "./login.component";
import { RouterModule } from "@angular/router";
import { SharedModule } from "src/app/shared/shared.modules";
import { MatButtonModule, MatFormFieldModule, MatInputModule, MatIconModule } from "@angular/material";

const routes = [
  {
    path: "login",
    component: LoginComponent
  }
];
@NgModule({
  declarations: [LoginComponent],
  imports: [
    RouterModule.forChild(routes),
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    SharedModule
  ]
})
export class LoginModule {}
