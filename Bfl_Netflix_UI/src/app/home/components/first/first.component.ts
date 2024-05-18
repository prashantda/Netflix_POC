import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.css']
})
export class FirstComponent {
@Input() show!:string;

constructor(private router:Router) {
  this.show="true";
}
SignIn(url:string){
this.router.navigateByUrl(url);
}
}
