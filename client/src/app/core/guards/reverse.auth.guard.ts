// Guard login/register routes from logged in user
import { Injectable } from "@angular/core";
import {
  CanActivate,
  Router,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from "@angular/router";
import { AuthService } from "../services/auth.service";

@Injectable()
export class ReverseAuthGuard implements CanActivate {
  constructor(private _router: Router, private _authService: AuthService) {}

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const userLoggedIn = this._authService.isLoggedIn();
    if (!userLoggedIn) {
      return true;
    } else {
      this._router.navigateByUrl("/my-theater");
      return false;
    }
  }
}
