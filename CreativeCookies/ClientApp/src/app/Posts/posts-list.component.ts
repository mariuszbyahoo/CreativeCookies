import { Component, OnInit } from "@angular/core";
import { IPost } from './post';
import { PostService } from './post.service';

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
  get listFilter(): string {
    return this._listFilter;
  }
  set listFilter(value: string) {
    this._listFilter = value;
    this.filteredPosts = this.listFilter ? this.performFilter(this.listFilter) : this.posts;
  }
  filteredPosts: IPost[];
  posts: IPost[];

  constructor(private postService: PostService) {
    this.listFilter = '';
  }

  // It'll be used later
  performFilter(filterBy: string): IPost[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.posts.filter((post: IPost) =>
      post.title.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }

  patchPost(id: string) {
    console.log(`PatchPost clicked on the image with ID of: ${id}`);
  }

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
  }

  // Here I will branch those posts, and decide, is it returning Trailers or Full movies.
  fetchPosts(): void {
    this.postService.getPosts().subscribe(posts => {
      this.posts = posts
      this.filteredPosts = this.posts;
    }),
      // I suppose, what here happens printing of 401 message
      err => this.errMsg = err;
  }
}
