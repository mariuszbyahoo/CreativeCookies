import { Component } from '@angular/core';
import { AuthService } from '../auth-service.component';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  constructor(private _authService: AuthService) {
  }
  isExpanded = false;
  isLoggedIn = this._authService.isLoggedIn().then(_result => this.isLoggedIn = _result);
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  login(){
    this._authService.login();
  }

  logout(){
    this._authService.logout();
  }
}
