import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AssetsComponent } from './assets/assets.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [AssetsComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'assets', component: AssetsComponent }
    ])
  ]
})
export class AssetsModule { }
