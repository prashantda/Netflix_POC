import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes,RouterModule, PreloadAllModules } from '@angular/router';
import { IndexComponent } from './home/components/index/index.component';
import { NotfoundComponent } from './shared/components/notfound/notfound.component';
import { SigninComponent } from './home/components/signin/signin.component';
import { PasswordComponent } from './home/components/password/password.component';
import { SelectPlanComponent } from './home/components/select-plan/select-plan.component';
import { CIndexComponent } from './customer/components/c-index/c-index.component';

const routes:Routes = [
{path:"",component:IndexComponent},
{path:"signin",component:SigninComponent},
{path:"signup/:mail",component:PasswordComponent},
{path:"select-plan",component:SelectPlanComponent},
 {path:"dashboard",component:CIndexComponent},



{path:"**",component:NotfoundComponent}
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot( routes, {preloadingStrategy: PreloadAllModules})
  ]
})
export class AppRoutingModule { }
