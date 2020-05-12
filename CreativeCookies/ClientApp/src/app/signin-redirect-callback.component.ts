import { Component, OnInit } from '@angular/core';
import { AuthService } from './auth-service.component';
import { Router } from '@angular/router';

@Component({
    selector: 'app-signin-redirect',
    template: `<div></div>`
})

export class SigninRedirectCallbackComponent implements OnInit {
    constructor(private _authService: AuthService, private _router: Router) { }

    ngOnInit() {
        this._authService.completeLogin().then(user => {
            this._router.navigate(['/'], {replaceUrl: true});
        })
     }
}