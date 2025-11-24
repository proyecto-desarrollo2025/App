import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DestinationRatingService {
  apiName = 'Default';
  

  rateDestination = (destinationId: string, score: number, comment: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: `/api/app/destination-rating/rate-destination/${destinationId}`,
      params: { score, comment },
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
