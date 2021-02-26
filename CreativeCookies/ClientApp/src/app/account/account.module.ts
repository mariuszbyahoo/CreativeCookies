import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { RegisterSuccessComponent } from './register-success/register-success.component';
import { RegisterDialogComponent } from './register-dialog/register-dialog.component';
import { RegisterComponentDialogComponent } from './register-component-dialog/register-component-dialog.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    RegisterComponent,
    RegisterSuccessComponent,
    RegisterDialogComponent,
    RegisterComponentDialogComponent
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
    RegisterComponentDialogComponent
  ]
})
export class AccountModule { }
