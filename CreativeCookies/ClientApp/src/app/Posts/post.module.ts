import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';

import { PostsListComponent } from './posts-list.component';
import { PostDetailsComponent } from './post-details.component';
import { PostDetailsGuard } from './post-details.guard';
import { SharedModule } from '../shared/shared.module';
import { PostFormComponent } from './post-form/post-form.component';
import { UpdatePostFormComponent } from './update-post-form/update-post-form.component';

@NgModule({
  declarations: [
    PostsListComponent,
    PostDetailsComponent,
    PostFormComponent,
    UpdatePostFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forChild([
      { path: 'posts', component: PostsListComponent },
      { path: 'posts/add', component: PostFormComponent }, // In this case everytime non-binding routes should be first!
      {path: 'posts/:id', 
        canActivate: [PostDetailsGuard],
        component: PostDetailsComponent
      },
      {path: 'posts/:id/edit', component: UpdatePostFormComponent}
   ]),
    SharedModule
  ],
  providers: [PostsListComponent]
})
export class PostModule {

}
