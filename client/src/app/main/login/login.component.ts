import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { AuthService } from "src/app/core/services/auth.service";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class LoginComponent implements OnInit {
  public loginForm: FormGroup;
  public loginError: string;

  constructor(
    private _formBuilder: FormBuilder,
    private _router: Router,
    private _authService: AuthService
  ) {}

  ngOnInit(): void {
    this.loginForm = this._formBuilder.group({
      email: ["", [Validators.required, Validators.email]],
      password: ["", Validators.required]
    });
  }

  handleLogin() {
    // Reset loginError
    this.loginError = '';

    const { email, password } = this.loginForm.value;
    this._authService
      .login(email, password)
      .subscribe(
        () => this._router.navigateByUrl("/my-theater"),
        error => this.handleError(error)
      );
  }

  handleError(error) {
    if (error.status >= 400 && error.status < 500) {
      this.loginError = error.error.message;
    } else if ( error.status >= 500) {
      // Show snackbar here
      console.error(error);
    } else {
      // No idea. Log this
      console.log(error);
    }
  }
}
