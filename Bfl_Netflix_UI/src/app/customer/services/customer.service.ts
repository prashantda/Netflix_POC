import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, retry, map, switchMap, of, ReplaySubject, tap, BehaviorSubject } from 'rxjs';
import { ApiConstants } from 'src/app/shared/constants/api-constants';
import { handleError } from 'src/app/shared/utilities/errorhandling';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  movieBaseUrl!: string;
  imageSubject: BehaviorSubject<string> = new BehaviorSubject<string>("");
  imageFetched: boolean = false;

  constructor(private httpClient: HttpClient) {
    this.movieBaseUrl = environment.movieBaseUrl;
  }

  GetBackGroundImage(): Observable<string> {
    if (this.imageFetched) {
      return this.imageSubject.asObservable();
    } else {
      return this.getBlobUrl().pipe(
        switchMap(response => {
          const imageUrl = response.data;
          return this.convertImageUrlToByteArray(imageUrl).pipe(
            map(byteArray => this.byteArrayToImage(byteArray))
          );
        }),
        tap(imageUrl => {
          this.imageSubject.next(imageUrl);
          this.imageFetched = true;
        })
      );
    }
  }

  convertImageUrlToByteArray(imageUrl: string): Observable<Uint8Array> {
    return this.httpClient.get(imageUrl, { responseType: 'arraybuffer' }).pipe(
      map(response => new Uint8Array(response))
    );
  }

  byteArrayToImage(byteArray: Uint8Array): string {
    const blob = new Blob([byteArray], { type: 'image/jpg' });
    const imageUrl = URL.createObjectURL(blob);
    return imageUrl;
  }

  getBlobUrl(blobName: string = 'FrontImage.jpg'): Observable<any> {
    return this.httpClient.get<any>(
      `${this.movieBaseUrl}${ApiConstants.GetBlobUrl}?blobName=${encodeURIComponent(blobName)}`
    ).pipe(
      retry(3),
      catchError(handleError<any>('getBlobUrl'))
    );
  }
}




