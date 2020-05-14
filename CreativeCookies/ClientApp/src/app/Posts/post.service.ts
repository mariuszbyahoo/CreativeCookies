import { Injectable, Inject } from '@angular/core';
import { IPost } from './post';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError, of, from } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { IPostFromForm } from './post-form/IPost-from-form';
import { AuthService } from '../auth-service.component';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  private url: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') url: string,
              private _authService: AuthService) {
    this.url = url + 'api/posts';
  }

  getPosts(): Observable<IPost[]> {
    return from(this._authService.getToken().then(token => {
      var header = new HttpHeaders().set("Authorization", `Bearer ${token}`);
      return this.http.get<IPost[]>(this.url, { headers: header }).toPromise();
    }));
  }

  getPost(id: string): Observable<IPost> {
    return from(this._authService.getToken().then(token => {
      var header = new HttpHeaders().set("Authorization", `Bearer ${token}`);
      return this.http.get<IPost>(`${this.url}/${id}`, { headers: header }).toPromise();
    }));
  }

  createPost(newPost: IPostFromForm): Observable<any> {
    return from(this._authService.getToken().then(token => {
      var header = new HttpHeaders().set("Authorization", `Bearer ${token}`);
      return this.http.post(this.url, newPost, { headers: header }).toPromise();
    }));
  }

  updatePost(id: string, newPost: IPost): Observable<IPost> {
    return from(this._authService.getToken().then(token => {
      var header = new HttpHeaders().set("Authorization", `Bearer ${token}`);
      return this.http.patch<IPost>(`${this.url}/${id}`, newPost, { headers: header }).toPromise();
    }));
  }

  deletePost(id: string): Observable<any> {
    const url = `${this.url}/${id}`;
    return from(this._authService.getToken().then(token => {
      var header = new HttpHeaders().set("Authorization", `Bearer ${token}`);
      return this.http.delete(url, { headers: header }).toPromise();
    }));
  }

  handleError(err: HttpErrorResponse) {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occured: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.headers}`;
      console.log(errorMessage);
      return throwError(errorMessage);
    }
  }
}
