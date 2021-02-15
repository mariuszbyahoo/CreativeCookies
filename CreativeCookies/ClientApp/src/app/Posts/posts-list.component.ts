import { Component, OnInit } from "@angular/core";
import { IPost } from './post';
import { PostService } from './post.service';
import { AuthService } from "../auth-service.component";

@Component({
  templateUrl: './posts-list.component.html',
  styleUrls: ['./posts-list-component.css'],
  providers: [PostService]
})

export class PostsListComponent implements OnInit {
  pageTitle: string = 'Posts List';
  imageWidth: number = 50;
  imageMargin: number = 2;
  showImage: boolean = false;
  errMsg: string;
  _listFilter: string;

  isAdmin: boolean = false;

  get listFilter(): string {
    return this._listFilter;
  }
  set listFilter(value: string) {
    this._listFilter = value;
    this.filteredPosts = this.listFilter ? this.performFilter(this.listFilter) : this.posts;
  }
  filteredPosts: IPost[];
  posts: IPost[];

  constructor(private postService: PostService, private authService: AuthService) {
    this.listFilter = '';
  }

  performFilter(filterBy: string): IPost[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.posts.filter((post: IPost) =>
      post.title.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }

  // patchPost(id: string) {
  //   // 1, call an API endpoint api/posts/${id}
  //   // 2, populate the form with received post's fields
  //       // 2.1. Have to send a variable 'id' to the another component somehow.
  //       // 2.2 create a constructor, where this id is required to run.
  //   // 3, on OK, perform PATCH request
  // }

  deletePost(id: string) {
    this.postService.deletePost(id).subscribe(post => {
      this.fetchPosts();
    },
      error => {
        throw new Error(error);
      });
  }

  ngOnInit(): void {
    this.fetchPosts();
    this.authService.checkIsAdmin().then(value => {
      this.isAdmin = value;
      console.log(`CheckIsAdmin result: ${value}`);
    });
  }

  fetchPosts(): void {
    this.postService.getPosts().subscribe(posts => {
      this.posts = posts
      this.filteredPosts = this.posts;
    }),
      err => this.errMsg = err;
  }
}
