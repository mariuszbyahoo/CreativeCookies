import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { RegisterSuccessComponent } from './register-success/register-success.component';
import { SharedModule } from '../shared/shared.module';
import { RegisterDialogComponent } from './register-dialog/register-dialog.component';
import { RegisterDialogContentComponent } from './register-dialog/register-dialog-content.component';
import { LoginDialogComponent } from './login-dialog/login-dialog.component';
import { LoginDialogContentComponent } from './login-dialog/login-dialog-content.component';



@NgModule({
  declarations: [
    RegisterComponent,
    RegisterSuccessComponent,
    RegisterDialogComponent,
    RegisterDialogContentComponent,
    LoginDialogComponent,
    LoginDialogContentComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    SharedModule,
    RouterModule.forChild([
      { path: 'register', component: RegisterComponent, pathMatch: 'full' },
      { path: 'register/success', component: RegisterSuccessComponent, pathMatch: 'full' }
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
