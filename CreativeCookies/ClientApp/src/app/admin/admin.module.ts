import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PanelComponent } from './panel/panel.component';
import { CashflowManagementComponent } from './cashflow-management/cashflow-management.component';
import { CommentsManagementComponent } from './comments-management/comments-management.component';
import { UsersManagementComponent } from './users-management/users-management.component';
import { InteractionSettingsComponent } from './interaction-settings/interaction-settings.component';



@NgModule({
  declarations: [
    PanelComponent,
    CashflowManagementComponent,
    CommentsManagementComponent,
    UsersManagementComponent,
    InteractionSettingsComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    PanelComponent,
    CashflowManagementComponent,
    CommentsManagementComponent,
    UsersManagementComponent,
    InteractionSettingsComponent
  ]
})
export class AdminModule { }
