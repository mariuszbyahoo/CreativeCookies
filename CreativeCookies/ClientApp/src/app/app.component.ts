import { Component, OnInit } from '@angular/core';
import { AuthService } from './auth-service.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit{
  
  title = 'CreativeCookies';
  isLoggedIn = false;
  isLoggedInPromise: Promise<boolean>
  constructor(private _authService: AuthService) {
    this._authService.loginChanged.subscribe(loggedIn =>{
      this.isLoggedIn = loggedIn;
    })
   }

  isExpanded = false;
  ngOnInit() {
    this.isLoggedInPromise = this._authService.isLoggedIn().then(_result => this.isLoggedIn = _result);
  }
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  login() {
    this._authService.login();
  }

  logout() {
    this._authService.logout();
  }
}
