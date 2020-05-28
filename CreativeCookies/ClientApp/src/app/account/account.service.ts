import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AuthService } from '../auth-service.component';
import { Observable, from } from 'rxjs';
import { IAccount } from './iaccount';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  
  private url: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') url: string,
              private _authService: AuthService) {
    this.url = url + 'api/posts';
  }

  createAccount(newUser: IAccount): Observable<any> {
    return this.http.post(this.url, newUser);
  }
}
