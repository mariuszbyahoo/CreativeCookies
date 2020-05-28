import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AuthService } from '../auth-service.component';
import { Observable, from } from 'rxjs';
import { IAccount } from './iaccount';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  
  private url: string = "https://localhost:5001/Account/Register";

  constructor(private http: HttpClient,
              private _authService: AuthService) {
  }

  createAccount(newUser: IAccount): Observable<any> {
    return this.http.post(this.url, newUser);
  }
}
