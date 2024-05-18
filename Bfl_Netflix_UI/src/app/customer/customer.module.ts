import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { CIndexComponent } from './components/c-index/c-index.component';
import { FrontComponent } from './components/front/front.component';
import { ListComponent } from './components/list/list.component';



@NgModule({
  declarations: [
    HeaderComponent,
    CIndexComponent,
    FrontComponent,
    ListComponent
    
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CIndexComponent
  ]
})
export class CustomerModule { }
