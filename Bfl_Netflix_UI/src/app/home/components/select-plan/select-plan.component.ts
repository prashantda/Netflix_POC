import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { HomeService } from '../../services/home.service';
import { SelectedPlanRequest } from '../../models/selectedplanrequest.interface';
import { ApiConstants } from 'src/app/shared/constants/api-constants';
import { Subscription } from 'rxjs';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-select-plan',
  templateUrl: './select-plan.component.html',
  styleUrls: ['./select-plan.component.css']
})
export class SelectPlanComponent {
  selected!: string;
  selctplan_sub!:Subscription
  constructor(private titleService: Title,
    private homeService: HomeService,
    private routerService:Router) 
  {
    this.titleService.setTitle("Select Plan");

  }
  ChoosePlan() {
    const selectedPlan:SelectedPlanRequest={
      token:localStorage.getItem(`${ApiConstants.NetflixToken}`)??'',
      selectedplan:this.selected
    }
   this.selctplan_sub= this.homeService.SelectPlan(selectedPlan).subscribe(
   { next: response => {
      this.routerService.navigateByUrl("dashboard");
   },
   error: (err:string)=>{
console.log(err);
   }
  });

  }
}
