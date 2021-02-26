import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { SigninRedirectCallbackComponent } from './signin-redirect-callback.component'
import { PostModule } from './Posts/post.module';
import { WelcomeComponent } from './Shared/welcome/welcome.component';
import { SignoutRedirectCallbackComponent } from './signout-redirect-callback.component';
import { MustSubscribeComponent } from './unauthorised/must-subscribe/must-subscribe.component';
import { UnauthorisedModule } from './unauthorised/unauthorised.module';
import { AccountModule } from './account/account.module';
import { SharedModule } from './shared/shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';



// Have to look over on how to import already organised components from a custom module,
// i. e. SharedModule -> WelcomeComponent, not to directly declare the WelcomeComponent
// in my app.module
@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    SigninRedirectCallbackComponent,
    SignoutRedirectCallbackComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),

    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    PostModule,
    UnauthorisedModule,
    AccountModule,
    SharedModule,
    RouterModule.forRoot([
    { path: '', component: WelcomeComponent, pathMatch: 'full' },
    { path: 'signin-callback', component: SigninRedirectCallbackComponent },
    { path: 'signout-callback', component: SignoutRedirectCallbackComponent },
    { path: 'subscribe', component: MustSubscribeComponent, pathMatch: 'full' }
], { relativeLinkResolution: 'legacy' }),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
