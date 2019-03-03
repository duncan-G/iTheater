import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";
import * as moment from "moment";
import { tap, shareReplay } from "rxjs/operators";
import * as jwt_decode from "jwt-decode";
import { BehaviorSubject, Observable } from "rxjs";
import { User } from "../models/user.interface";
import { environment } from "src/environments/environment";

@Injectable()
export class AuthService {
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser$: Observable<User>;

  constructor(private router: Router, private http: HttpClient) {
    const user = JSON.parse(localStorage.getItem("currentUser"));
    this.currentUserSubject = new BehaviorSubject<User>(user);
    this.currentUser$ = this.currentUserSubject.asObservable();
  }

  register(email: string, password) {
    const registerUrl = environment.serverUrl + "auth/users/register";
    return this.http
      .post<User>(registerUrl, {
        email,
        password,
      })
      .pipe(
        tap(data => this.saveUser(data)),
        shareReplay()
      );
  }

  login(email: string, password: string) {
    const loginUrl = environment.serverUrl + "auth/users/login";
    return this.http.post<User>(loginUrl, { email, password }).pipe(
      tap(data => this.saveUser(data)),
      shareReplay()
    );
  }

  logout() {
    localStorage.removeItem("currentUser");
    this.currentUserSubject.next(null);
    this.router.navigateByUrl("/");
  }

  private saveUser(user: User) {
    this.currentUserSubject.next(user);
    localStorage.setItem("currentUser", JSON.stringify(user));
  }

  public getToken() {
    return this.currentUserSubject.value && this.currentUserSubject.value.token;
  }

  getExpiration(token) {
    const decoded = jwt_decode(token);
    return decoded.exp;
  }

  canBeLoggedIn(token) {
    const expiresIn = moment().add(this.getExpiration(token), "second");
    return moment().isBefore(expiresIn);
  }

  public isLoggedIn() {
    const token = this.getToken();
    return token ? this.canBeLoggedIn(token) : false;
  }
}
