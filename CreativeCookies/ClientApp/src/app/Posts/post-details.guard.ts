import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../auth-service.component';

@Injectable({
  providedIn: 'root'
})
export class PostDetailsGuard implements CanActivate {

  constructor(private _router: Router, private _authService : AuthService){

  }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    var res = true;
    var roles = ['paidUser', 'admin']
    this._authService.checkRole(roles).then(result => {
      if (!result) {
        res = false;
        this._router.navigate(['subscribe']);
      }
    });
    return res;
  }
}

      // let id = next.url[1].path;
    // if( !/^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$/.test(id)){
    //   alert('cannot open post when the posts Id is invalid');
    //   this.router.navigate(['/posts']);
    //   return false;
    // }
    // else{
    //   return true;
    // }
