import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth-service.component';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  title = 'CreativeCookies';
  isLoggedIn = false;
  isLoggedInPromise: Promise<boolean>
  constructor(private _authService: AuthService) {
    this._authService.loginChanged.subscribe(loggedIn => {
      this.isLoggedIn = loggedIn;
    }) }

  ngOnInit(): void {
    this.isLoggedInPromise = this._authService.isLoggedIn().then(_result => this.isLoggedIn = _result);
  }

  login() {
    this._authService.login();
  }

  logout() {
    this._authService.logout();
  }
}
