import { Component } from '@angular/core';

@Component({
  selector: 'app-destinations-list',
  templateUrl: './destinations-list.component.html',
  styleUrls: ['./destinations-list.component.scss'],
})
export class DestinationsListComponent {
  // Datos de prueba para que la vista funcione
  destinations = [
    { name: 'Buenos Aires' },
    { name: 'Córdoba' },
    { name: 'Rosario' }
  ];
}
