import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import {
  FormGroup,
  FormBuilder,
  Validators,
  ValidatorFn,
  AbstractControl,
  ValidationErrors
} from "@angular/forms";
import { AuthService } from "src/app/core/services/auth.service";
import { Router } from "@angular/router";

@Component({
  selector: "app-register",
  templateUrl: "./register.component.html",
  styleUrls: ["./register.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class RegisterComponent implements OnInit {
  public registerForm: FormGroup;
  public registerError: string;

  constructor(
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      email: ["", [Validators.required, Validators.email]],
      password: ["", Validators.required],
      passwordConfirm: ["", [Validators.required, confirmPasswordValidator]]
    });
  }

  handleRegister() {
    const { email, password } = this.registerForm.value;
    this.authService
      .register(email, password)
      .subscribe(
        () => this.router.navigateByUrl("/my-theater"),
        error => this.handleError(error)
      );
  }

  handleError(error) {
    if (error.status >= 400 && error.status < 500) {
      this.registerError = error.error.message;
    } else if (error.status >= 500) {
      // Show snackbar here
      console.error(error);
    } else {
      // No idea. Log this
      console.log(error);
    }
  }
}

export const confirmPasswordValidator: ValidatorFn = (
  control: AbstractControl
): ValidationErrors | null => {
  if (!control.parent || !control) {
    return null;
  }

  const password = control.parent.get("password");
  const passwordConfirm = control.parent.get("passwordConfirm");

  if (!password || !passwordConfirm) {
    return null;
  }

  if (passwordConfirm.value === "") {
    return null;
  }

  if (password.value === passwordConfirm.value) {
    return null;
  }

  return { passwordsNotMatching: true };
};
