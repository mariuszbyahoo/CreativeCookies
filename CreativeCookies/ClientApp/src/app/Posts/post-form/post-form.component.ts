import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { PostService } from '../post.service';
import { IPostFromForm } from './IPost-from-form';
import { PostsListComponent } from '../posts-list.component';

@Component({
  selector: 'app-post-form',
  templateUrl: './post-form.component.html',
  styleUrls: ['./post-form.component.css']
})
export class PostFormComponent implements OnInit {
  post: IPostFromForm = {
    title: null,
    description: null,
    content: null,
    imageUrl: null,
    videoUrl: null
  };
  postError = false;
  postErrorMessage = '';

  constructor(private router: Router, private postService: PostService, private list: PostsListComponent) { }

  onBack(): void {
    this.router.navigate(['/posts']);
  }

  ngOnInit() {
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this.postService.createPost(this.post).subscribe(
        result => console.log('result ', result),
        error => this.postService.handleError(error)
      );
      this.router.navigate(['/']);
    }
    else {
      this.postError = true;
      this.postErrorMessage = 'Fix your data and try again';
    }
  }
}
