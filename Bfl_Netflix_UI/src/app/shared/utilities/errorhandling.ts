import { HttpErrorResponse } from "@angular/common/http";
import { Observable, throwError } from "rxjs";

export function handleError<T>(operation:string='One'){
return (err:HttpErrorResponse):Observable<T>=>{
console.log(`${operation} operation failed: ${err.message}`)
return throwError(()=>err.message)
}
}
