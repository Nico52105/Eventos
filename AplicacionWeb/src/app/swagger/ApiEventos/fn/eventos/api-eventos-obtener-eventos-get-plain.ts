/* tslint:disable */
/* eslint-disable */
/* Code generated by ng-openapi-gen DO NOT EDIT. */

import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ContratoEventoListRespuestaGeneral } from '../../models/contrato-evento-list-respuesta-general';

export interface ApiEventosObtenerEventosGet$Plain$Params {
}

export function apiEventosObtenerEventosGet$Plain(http: HttpClient, rootUrl: string, params?: ApiEventosObtenerEventosGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<ContratoEventoListRespuestaGeneral>> {
  const rb = new RequestBuilder(rootUrl, apiEventosObtenerEventosGet$Plain.PATH, 'get');
  if (params) {
  }

  return http.request(
    rb.build({ responseType: 'text', accept: 'text/plain', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return r as StrictHttpResponse<ContratoEventoListRespuestaGeneral>;
    })
  );
}

apiEventosObtenerEventosGet$Plain.PATH = '/api/Eventos/ObtenerEventos';