import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MustSubscribeComponent } from './must-subscribe/must-subscribe.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [MustSubscribeComponent],
  imports: [
    CommonModule,
    RouterModule.forRoot([], { relativeLinkResolution: 'legacy' })
  ]
})
export class UnauthorisedModule { }
