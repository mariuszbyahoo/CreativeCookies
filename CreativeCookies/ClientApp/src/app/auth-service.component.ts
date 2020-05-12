import { Injectable } from '@angular/core';
import { UserManager } from 'oidc-client';
import { User } from 'oidc-client';
import { Constants } from './constants.component';
import { Subject } from 'rxjs';

@Injectable({providedIn: 'root'})
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
            scope: 'openid profile',
            response_type: 'code',
            post_logout_redirect_uri: `${Constants.clientRoot}signout-callback`
        };
        this._userManager = new UserManager(idpSettings);
    }
    
    login() {
        return this._userManager.signinRedirect();
    }

    completeLogin() {
        return this._userManager.signinRedirectCallback().then(user => {
          this._user = user;
          this._loginChangedSubject.next(!!user && !user.expired);
          return user;
        });
      }
      
      logout() {
        this._userManager.signoutRedirect();
      }  

      completeLogout() {
        this._user = null;
        return this._userManager.signoutRedirectCallback();
      }

    isLoggedIn(): Promise<boolean> {
        return this._userManager.getUser().then(user =>{
            // check, is the user not null (!!user) and
            // hasn't he expired:
            const currentUserIsValid = !!user && !user.expired; 
            if(this._user !== user){
                this._loginChangedSubject.next(currentUserIsValid);
            }
            this._user = user;
            return currentUserIsValid
        })
    }
}
