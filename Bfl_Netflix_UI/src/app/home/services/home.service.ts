import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, retry } from 'rxjs';
import { SignUpRequest } from '../models/signuprequest.interface';
import { environment } from 'src/environments/environment.development';
import { ApiConstants } from 'src/app/shared/constants/api-constants';
import { handleError } from 'src/app/shared/utilities/errorhandling';
import { SelectedPlanRequest } from '../models/selectedplanrequest.interface';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  movieBaseUrl: string;

  constructor(private httpClient: HttpClient) {
    this.movieBaseUrl = environment.movieBaseUrl;
  }


  SignUp(request: SignUpRequest): Observable<any> {
    console.log(request);

    return this.httpClient.post<any>(`${this.movieBaseUrl}${ApiConstants.SignUp}`, request)
      .pipe(
        retry(3),
        catchError(handleError<any>('Signup'))
      );
  }

  SelectPlan(request:SelectedPlanRequest):Observable<any>{
    return this.httpClient.post<any>(`${this.movieBaseUrl}${ApiConstants.SelectPlan}`,request)
    .pipe(
      retry(3),
      catchError(handleError<any>('SelectPlan'))
    );
  }

  SignIn(request:SignUpRequest):Observable<any>{
  return  this.httpClient.post(`${this.movieBaseUrl}${ApiConstants.SignIn}`,request).
  pipe(
    retry(3),
    catchError(handleError<any>('SignIn'))
  );
  
  }



}
