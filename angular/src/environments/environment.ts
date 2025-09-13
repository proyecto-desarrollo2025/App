import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44379/',
  redirectUri: baseUrl,
  clientId: 'ProyectoDesarrollo2025_App',
  responseType: 'code',
  scope: 'offline_access ProyectoDesarrollo2025',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ProyectoDesarrollo2025',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44379',
      rootNamespace: 'ProyectoDesarrollo2025',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
