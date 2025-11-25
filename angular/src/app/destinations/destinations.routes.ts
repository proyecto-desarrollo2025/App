import { Routes } from '@angular/router';
import { authGuard } from '@abp/ng.core';

export const DESTINATIONS_ROUTES: Routes = [
  {
    path: '',
    canActivate: [authGuard],
    loadComponent: () =>
      import('./destinations-list/destinations-list.component').then(
        (c) => c.DestinationsListComponent
      ),
  },
];

