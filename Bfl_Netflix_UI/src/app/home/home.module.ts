import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IndexComponent } from './components/index/index.component';
import { EnjoytvComponent } from './components/enjoytv/enjoytv.component';
import { DownloadComponent } from './components/download/download.component';
import { WatcheverywhereComponent } from './components/watcheverywhere/watcheverywhere.component';
import { KidsprofileComponent } from './components/kids-profile/kidsprofile.component';
import { FaqComponent } from './components/faq/faq.component';
import { FirstComponent } from './components/first/first.component';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from '../app-routing.module';
import { GetstartedComponent } from './components/getstarted/getstarted.component';
import { SigninComponent } from './components/signin/signin.component';
import { SharedModule } from '../shared/shared.module';
import { HeaderComponent } from './components/header/header.component';
import { FrontfooterComponent } from './components/frontfooter/frontfooter.component';
import { PasswordComponent } from './components/password/password.component';
import { SelectPlanComponent } from './components/select-plan/select-plan.component';



@NgModule({
  declarations: [
    IndexComponent,
    EnjoytvComponent,
    DownloadComponent,
    WatcheverywhereComponent,
    KidsprofileComponent,
    FaqComponent,
    FirstComponent,
    GetstartedComponent,
    SigninComponent,
    HeaderComponent,
    FrontfooterComponent,
    PasswordComponent,
    SelectPlanComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    SharedModule
    
    
  ],
  exports:[
    IndexComponent
  ]
})
export class HomeModule { }
