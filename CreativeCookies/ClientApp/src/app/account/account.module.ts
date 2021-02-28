import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { RegisterSuccessComponent } from './register-success/register-success.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    RegisterComponent,
    RegisterSuccessComponent,
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
  ]
})
export class AccountModule { }
