import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import { IPost } from './post';
import { PostService } from './post.service';

@Component({
  templateUrl: './post-details.component.html',
  styleUrls: ['./post-details.component.css']
})
export class PostDetailsComponent implements OnInit {
  pageTitle:  string = "Post Details";
  post: IPost;
  errMsg: string;

  constructor(private route: ActivatedRoute, private postSrv: PostService, private router: Router) { }

  ngOnInit(): void {
    this.postSrv.getPost(this.route.snapshot.paramMap.get('id')).subscribe({
      next: post => {
        this.post = post
      },
      error: err => {
        this.errMsg = err
      }
    });
  }

  onBack(): void {
    this.router.navigate(['/posts']);
  }
}
