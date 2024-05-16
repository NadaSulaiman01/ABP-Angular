import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AngularDotNet',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44397/',
    redirectUri: baseUrl,
    clientId: 'AngularDotNet_App',
    responseType: 'code',
    scope: 'offline_access AngularDotNet',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44397',
      rootNamespace: 'AngularDotNet',
    },
  },
} as Environment;
