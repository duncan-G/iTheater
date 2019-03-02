import { NgModule } from "@angular/core";
import { RegisterComponent } from "./register.component";
import { RouterModule } from "@angular/router";
import { SharedModule } from "src/app/shared/shared.module";
import { MatButtonModule, MatFormFieldModule, MatInputModule, MatIconModule } from "@angular/material";

const routes = [
  {
    path: "register",
    component: RegisterComponent
  }
];
@NgModule({
  declarations: [RegisterComponent],
  imports: [
    RouterModule.forChild(routes),
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    SharedModule
  ]
})
export class RegisterModule {}
