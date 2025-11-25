import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CoreModule } from '@abp/ng.core';

import { DestinationService } from '../../proxy/destinations/destination.service';
import { CitySearchRequestDto, CitySearchResultDto } from '../../proxy/application/contracts/destinations/models';

@Component({
  selector: 'app-destinations-list',
  standalone: true,
  imports: [CommonModule, FormsModule, CoreModule],
  templateUrl: './destinations-list.component.html',
  styleUrls: ['./destinations-list.component.scss'],
})
export class DestinationsListComponent implements OnInit {

  private readonly destinationService = inject(DestinationService);

  cities: any[] = [];
  loading = false;

  searchParams: CitySearchRequestDto = {
    partialName: '',
    limit: 10,
    countryCode: ''
  };

  ngOnInit(): void {
    // No cargar automáticamente. El usuario debe ingresar countryCode primero.
  }

  search(): void {
    // Validar countryCode
    if (!this.searchParams.countryCode || this.searchParams.countryCode.trim().length !== 2) {
      console.warn("CountryCode inválido");
      this.cities = [];
      return;
    }

    // Validar texto de búsqueda
    if (!this.searchParams.partialName || this.searchParams.partialName.trim().length < 2) {
      console.warn("Nombre de ciudad inválido");
      this.cities = [];
      return;
    }

    this.loading = true;

    this.destinationService.searchCities(this.searchParams)
      .subscribe({
        next: (result: CitySearchResultDto) => {
          this.cities = result.cities || [];
          this.loading = false;
        },
        error: (error) => {
          console.error("Error desde API:", error);
          this.cities = [];
          this.loading = false;
        }
      });
  }

  clear(): void {
    this.searchParams.partialName = '';
    this.searchParams.countryCode = '';
    this.cities = [];
  }

  openInMaps(city: any): void {
    if (!city.latitude || !city.longitude) return;

    const googleUrl = `https://www.google.com/maps/search/?api=1&query=${city.latitude},${city.longitude}`;
    window.open(googleUrl, '_blank');
  }
    isFormValid(): boolean {
    const countryOk = this.searchParams.countryCode?.trim().length === 2;
    const cityOk = this.searchParams.partialName?.trim().length >= 2;
    return countryOk && cityOk;
  }   
}
