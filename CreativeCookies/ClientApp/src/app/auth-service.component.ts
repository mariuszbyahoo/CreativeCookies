import { Injectable } from '@angular/core';
import { UserManager } from 'oidc-client';
import { User } from 'oidc-client';
import { Constants } from './constants.component';
import { Subject } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class AuthService {

  private _userManager: UserManager;
  private _user: User;
  private _loginChangedSubject = new Subject<boolean>();

  loginChanged = this._loginChangedSubject.asObservable();
  constructor() {
    const idpSettings = {
      authority: Constants.idpRoot,
      client_id: Constants.clientId,
      redirect_uri: `${Constants.clientRoot}signin-callback`,
      scope: 'openid profile roles api',
      response_type: 'code',
      post_logout_redirect_uri: `${Constants.clientRoot}signout-callback`,
      automaticSilentRenew: true,
      silent_redirect_uri: `${Constants.clientRoot}assets/silent-callback.html`
    };
    this._userManager = new UserManager(idpSettings);
    this._userManager.events.addAccessTokenExpired(() => {
      this._loginChangedSubject.next(false);
    })
  }

  login() {
    return this._userManager.signinRedirect();
  }

  checkIsSubscriber(): Promise<boolean>{
    var state: boolean = false;
    return this.isLoggedIn().then(value => {
      state = value;
      if(state){
        return this._userManager.getUser().then(user => {
          if (user.profile.role.toLowerCase() === 'paiduser' || user.profile.role.toLowerCase() === 'admin') {
            return true;
          }
          else {
            return false;
          }
        })
      }
    })
  }

  completeLogin() {
    return this._userManager.signinRedirectCallback().then(user => {
      this._user = user;
      this._loginChangedSubject.next(!!user && !user.expired);
      return user;
    });
  }

  checkIsAdmin() : Promise<boolean>{
    var state: boolean = false;
    return this.isLoggedIn().then(value => {
      state = value;
      if (state) {
        return this._userManager.getUser().then(user => {
          if (user.profile.role.toLowerCase() === 'admin') {
            return true;
          }
          else {
            return false;
          }
        });
      }
    });
  }

  logout() {
    this._userManager.signoutRedirect();
  }

  completeLogout() {
    this._user = null;
    this._loginChangedSubject.next(false);
    return this._userManager.signoutRedirectCallback();
  }

  isLoggedIn(): Promise<boolean> {
    return this._userManager.getUser().then(user => {
      // check, is the user not null (!!user) and
      // hasn't he expired:
      const currentUserIsValid = !!user && !user.expired;
      if (this._user !== user) {
        this._loginChangedSubject.next(currentUserIsValid);
      }
      this._user = user;
      return currentUserIsValid
    })
  }

  getToken() {
    return this._userManager.getUser().then(user => {
      if (!!user && !user.expired) {
        return user.access_token; 
      }
      else {
        return null;
      }
    });
  }
}
