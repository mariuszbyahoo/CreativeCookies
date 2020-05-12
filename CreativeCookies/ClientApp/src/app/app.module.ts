import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { SigninRedirectCallbackComponent } from './signin-redirect-callback.component'
import { PostModule } from './Posts/post.module';
import { WelcomeComponent } from './Shared/welcome/welcome.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SignoutRedirectCallbackComponent } from './signout-redirect-callback.component';

// Have to look over on how to import already organised components from a custom module,
// i. e. SharedModule -> WelcomeComponent, not to directly declare the WelcomeComponent
// in my app.module
@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    SigninRedirectCallbackComponent,
    SignoutRedirectCallbackComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    PostModule,
    RouterModule.forRoot([
      {path: '', component: WelcomeComponent, pathMatch : 'full'},
      {path: 'signin-callback', component: SigninRedirectCallbackComponent},
      {path: 'signout-callback', component: SignoutRedirectCallbackComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
