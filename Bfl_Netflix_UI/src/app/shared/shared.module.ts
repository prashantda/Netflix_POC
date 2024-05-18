import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { FooterComponent } from './components/footer/footer.component';



@NgModule({
  declarations: [
    NotfoundComponent,
    FooterComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    NotfoundComponent,
    FooterComponent
  ]
})
export class SharedModule { }
