import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormControl,FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-getstarted',
  templateUrl: './getstarted.component.html',
  styleUrls: ['./getstarted.component.css']
})
export class GetstartedComponent implements OnInit{
regForm!:FormGroup;
constructor(private routerService:Router,private frmBuilder:FormBuilder) {
  // this.regForm=this.frmBuilder.group({
  //   email:""
  // })
}
ngOnInit(): void {
  this.regForm = this.frmBuilder.group({
    email: ['', [Validators.required, Validators.email]]
  });
}
getRegForm(){
 return this.frmBuilder.control;
}

SignUp(){
  if(this.regForm.controls['email'].valid){
    const emailid=this.regForm.value; 
    this.routerService.navigate(['/signup',emailid.email]);
  }
  else{
    const emailInput=document.querySelector('[formControlName="email"]') as HTMLElement
    if(emailInput){
      emailInput.focus()
    }
  }

}
}
