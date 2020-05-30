import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { RegisterSuccessComponent } from './register-success/register-success.component';



@NgModule({
  declarations: [RegisterComponent, RegisterSuccessComponent],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild([
      { path: 'register', component: RegisterComponent, pathMatch: 'full' },
      { path: 'register/success', component: RegisterSuccessComponent, pathMatch: 'full' }
    ])
  ]
})
export class AccountModule { }
