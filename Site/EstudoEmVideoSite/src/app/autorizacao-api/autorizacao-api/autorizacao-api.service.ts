import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'
import { AutorizacaoApiResponse } from './autorizacao-api-response';
import { AutorizacaoApiRequest } from './autorizacao-api-request';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class AutorizacaoApiService {

  private autorizacaoURl: string = "https://estudoemvideo.acmesistemas.com.br/EstudoEmVideo/AutorizacaoApi";
  _request :AutorizacaoApiRequest  = new AutorizacaoApiRequest();
 _autoricaoApiResponse: AutorizacaoApiResponse = new AutorizacaoApiResponse();

 constructor(private httpClient: HttpClient) {

 }

 AutorizacaoApi(): Observable<AutorizacaoApiResponse>
 {
   return this.httpClient.post<AutorizacaoApiResponse>(this.autorizacaoURl, this._request,{
     headers: new HttpHeaders()
   });
 }

 SetCompetencias() : void{
   this.AutorizacaoApi().subscribe({
     next:(autorizcaoApiResponse: AutorizacaoApiResponse) => {
       this._autoricaoApiResponse = autorizcaoApiResponse;
     },
     error: err=>console.log("ERRO: ",err)
   });
 }

 GetCompetencias() : AutorizacaoApiResponse{
   return this._autoricaoApiResponse;
 }}
