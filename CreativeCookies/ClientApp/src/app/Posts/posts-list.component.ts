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

  async deletePost(id: string) {
    await this.postService.deletePost(id).subscribe({
      next() {
      },
      error() {
      },
      complete: () => this.fetchPosts()
    })
  }

  ngOnInit(): void {
    this.fetchPosts();
  }

  fetchPosts(): void {
    this.postService.getPosts().subscribe({
      next: posts => {
        this.posts = posts
        this.filteredPosts = this.posts;
      },
      error: err => this.errMsg = err
    });
  }
}
