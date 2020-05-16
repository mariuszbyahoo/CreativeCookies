import { Component, OnInit } from '@angular/core';
import { PostService } from '../post.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IPostFromForm } from '../post-form/IPost-from-form';
import { NgForm } from '@angular/forms';
import { PostsListComponent } from '../posts-list.component';

@Component({
  selector: 'app-update-post-form',
  templateUrl: './update-post-form.component.html',
  styleUrls: ['./update-post-form.component.css']
})
export class UpdatePostFormComponent implements OnInit {
  post: IPostFromForm;
  _patchErrorMessage: string;
  _patchError: boolean = false;
  _id: string;

  constructor(private _postService : PostService, private _route: ActivatedRoute, 
              private _router: Router, private _list: PostsListComponent) {
                this._id = this._route.snapshot.paramMap.get('id');
              }

  ngOnInit() {
    this._postService.getPost(this._id).subscribe({
      next: post => {
        this.post = post
      },
      error: err => {
        window.alert("You have to log in.");
      }
    });
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this._postService.updatePost(this._id, this.post).subscribe(
        result => console.log('result ', result),
        error => this._postService.handleError(error)
      );
      this._list.fetchPosts(); // reload the list
      this._router.navigate(['/posts']);
    }
    else {
      this._patchError = true;
      this._patchErrorMessage = 'Fix your data and try again';
    }
  }

  onBack(): void {
    this._router.navigate(['/posts']);
  }
}
