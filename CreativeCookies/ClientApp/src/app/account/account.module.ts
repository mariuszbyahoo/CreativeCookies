import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterSuccessComponent } from './register-success/register-success.component';
import { SharedModule } from '../shared/shared.module';
import { RegisterDialogComponent } from './register-dialog/register-dialog.component';
import { LoginDialogComponent } from './login-dialog/login-dialog.component';
import { RegisterDialogContentComponent } from './register-dialog/register-dialog-content/register-dialog-content.component';
import { LoginDialogContentComponent } from './login-dialog/login-dialog-content/login-dialog-content.component';
import { TermsComponent } from './terms/terms.component';



@NgModule({
  declarations: [
    RegisterComponent,
    RegisterSuccessComponent,
    RegisterDialogComponent,
    RegisterDialogContentComponent,
    LoginDialogComponent,
    LoginDialogContentComponent,
    TermsComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    SharedModule,
    ReactiveFormsModule,
    RouterModule.forChild([
      { path: 'register', component: RegisterComponent, pathMatch: 'full' },
      { path: 'register/success', component: RegisterSuccessComponent, pathMatch: 'full' },
      { path: 'terms', component: TermsComponent, pathMatch:'full' }
    ])
  ],
  exports: [
    RegisterDialogComponent,
    RegisterDialogContentComponent,
    LoginDialogComponent,
    LoginDialogContentComponent
  ]
})
export class AccountModule { }
