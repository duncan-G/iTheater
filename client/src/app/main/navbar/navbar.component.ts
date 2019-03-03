import { Component, ViewEncapsulation, OnInit } from "@angular/core";
import { User } from "src/app/core/models/user.interface";
import { AuthService } from "src/app/core/services/auth.service";

@Component({
  selector: "app-navbar",
  templateUrl: "./navbar.component.html",
  styleUrls: ["./navbar.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class NavbarComponent implements OnInit {
  public userLoggedIn: boolean;

  constructor(private _authService: AuthService) {
    this._authService.currentUser$.subscribe(user => {
      this.userLoggedIn = this._authService.isLoggedIn();
    });
  }

  handleLogout() {
    this._authService.logout();
  }

  ngOnInit() {}
}
