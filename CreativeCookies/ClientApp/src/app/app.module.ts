import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { SigninRedirectCallbackComponent } from './signin-redirect-callback.component'
import { PostModule } from './Posts/post.module';
import { WelcomeComponent } from './Shared/welcome/welcome.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SignoutRedirectCallbackComponent } from './signout-redirect-callback.component';
import { MustSubscribeComponent } from './unauthorised/must-subscribe/must-subscribe.component';
import { UnauthorisedModule } from './unauthorised/unauthorised.module';
import { AccountModule } from './account/account.module';
import { MatButtonModule } from '@angular/material';

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
    MatButtonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    PostModule,
    UnauthorisedModule,
    AccountModule,
    RouterModule.forRoot([
      {path: '', component: WelcomeComponent, pathMatch : 'full'},
      {path: 'signin-callback', component: SigninRedirectCallbackComponent},
      {path: 'signout-callback', component: SignoutRedirectCallbackComponent},
      { path: 'subscribe', component: MustSubscribeComponent, pathMatch: 'full' }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
