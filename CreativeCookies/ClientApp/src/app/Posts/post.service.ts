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
    //var response;
    //fetch(this.url, {
    //  method: 'get',
    //  headers: new Headers({
    //    'Authorization': `Bearer ${_token}`
    //  })
    //}).then(res => {
    //  response = res
    //});
    
  }

  getPost(id: string): Observable<IPost> {
    return this.http.get<IPost>(`${this.url}/${id}`).pipe(
      tap(data => console.log(`Specific: ${JSON.stringify(data)}`)),
      catchError(this.handleError)
    );
  }

  createPost(newPost: IPostFromForm): Observable<any> {

    return this.http.post(this.url, newPost).pipe(
      tap(data => console.log(`Created: ${JSON.stringify(data)}`)),
      catchError(this.handleError));
  }

  updatePost(id: string, newPost: IPost): Observable<IPost> {
    return this.http.patch<IPost>(`${this.url}/${id}`, newPost).pipe(
      tap(data => console.log(`Created: ${JSON.stringify(data)}`)),
      catchError(this.handleError)
    )
  }

  deletePost(id: string) {
    const url = `${this.url}/${id}`;
    return this.http.delete(url);
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
