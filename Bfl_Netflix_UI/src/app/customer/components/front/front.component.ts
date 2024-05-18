import { Component, OnDestroy, OnInit } from '@angular/core';
import { CustomerService } from '../../services/customer.service';
import { Subscription, concatMap } from 'rxjs';

@Component({
  selector: 'app-front',
  templateUrl: './front.component.html',
  styleUrls: ['./front.component.css']
})
export class FrontComponent implements OnInit, OnDestroy {
  backImage!: string;
  backImageSub!: Subscription;
  constructor(private customerService: CustomerService) {

    
  }
  ngOnInit():void {
    this.backImageSub = this.customerService.GetBackGroundImage()
    .subscribe({next:response => {
      this.backImage = response;
    }, error:err => {
      console.log(err);
    }});
  }
  
  ngOnDestroy(): void {
    this.backImageSub.unsubscribe();
  }

}
 
/* ngOnInit():void {
    this.backImageSub = this.customerService.GetBackGroundImage().pipe(
      concatMap(response1 => {
        this.backImage = response1;
        return this.customerService.GetBackGroundImage();
      })
    ).subscribe({next:response2 => {
      this.ndBackImage = response2;
    }, error:err => {
      console.log(err);
    }});
  } */
