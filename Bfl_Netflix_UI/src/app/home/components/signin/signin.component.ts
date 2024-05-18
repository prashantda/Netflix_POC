import { Component, OnDestroy, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { HomeService } from '../../services/home.service';
import { Subscription } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiConstants } from 'src/app/shared/constants/api-constants';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit, OnDestroy {
  signIn_sub!: Subscription;
  signinForm!: FormGroup;
  constructor(private titleSerive: Title,
    private routerService: Router,
    private homeService: HomeService,
    private frm_builder: FormBuilder) {

    this.signinForm = this.frm_builder.group({
      email: ['', [Validators.required, Validators.email, Validators.maxLength(63)]],
      password: ['', [Validators.required]]
    })

  }
  get f() { return this.signinForm.controls; }
  ngOnDestroy(): void {
    this.signIn_sub.unsubscribe();

  }
  ngOnInit(): void {
    this.titleSerive.setTitle("SignIn")
  }

  SignIn() {
    this.signIn_sub = this.homeService.SignIn(this.signinForm.value).subscribe({
      next:response =>{
        console.log(response)
        localStorage.setItem(`${ApiConstants.NetflixToken}`,response.data);
        this.routerService.navigateByUrl(`dashboard`);
      },
      error: (err:string)=>{
        console.log(err);
        this.routerService.navigateByUrl(`dashboard`);

      }
    })
  }
}
