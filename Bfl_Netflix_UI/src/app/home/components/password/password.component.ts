import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { HomeService } from '../../services/home.service';
import { NgModule } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ApiConstants } from 'src/app/shared/constants/api-constants';

@Component({
  selector: 'app-password',
  templateUrl: './password.component.html',
  styleUrls: ['./password.component.css']
})
export class PasswordComponent implements OnInit, OnDestroy {
  regForm!: FormGroup;
  emailid!: String;
  routeSub: Subscription;
  signupSub?: Subscription;
  showPassword=true;
  constructor(private frmBuilder: FormBuilder, 
    private route: ActivatedRoute, 
    private homeService: HomeService,
    private routerService:Router,
    private titleService:Title) {
      this.titleService.setTitle("Set Password")
    // this.emailid=route.snapshot.queryParamMap.get('email')??''; //To read query Parameter
    this.routeSub = this.route.params.subscribe(params => {
      this.regForm = frmBuilder.group({
        email: [params['mail'],[Validators.required,Validators.email,Validators.maxLength(63)]],
        password: ['',[Validators.required,Validators.minLength(7),Validators.maxLength(15), Validators.pattern(/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)[a-zA-Z\d\W]{7,15}$/)]]
      });
    })

  }
  get f() { return this.regForm.controls; }
  SignUp() {
    if (this.regForm.valid) {
      this.signupSub = this.homeService.SignUp(this.regForm.value).subscribe({
        next: response => {
         
          localStorage.setItem(`${ApiConstants.NetflixToken}`,response.data);
          this.routerService.navigateByUrl("select-plan");
        },
        error: (err: string) => {
          console.log(err)
        }
      });

    }
    else {
      console.log()
      this.regForm.markAllAsTouched();
    }
  }


  ngOnInit(): void {

  }
  ngOnDestroy(): void {
    this.routeSub.unsubscribe();
    this.signupSub?.unsubscribe();
  }




}
