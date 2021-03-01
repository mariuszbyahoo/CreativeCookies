import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { RegisterDialogComponent } from './register-dialog/register-dialog.component';
import { RegisterDialogContentComponent } from './register-dialog/register-dialog-content/register-dialog-content.component';
import { TermsComponent } from './terms/terms.component';



@NgModule({
  declarations: [
    RegisterDialogComponent,
    RegisterDialogContentComponent,
    TermsComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    SharedModule,
    ReactiveFormsModule,
    RouterModule.forChild([
      { path: 'terms', component: TermsComponent, pathMatch:'full' }
    ])
  ],
  exports: [
    RegisterDialogComponent,
    RegisterDialogContentComponent,
  ]
})
export class AccountModule { }
