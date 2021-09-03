import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Response } from 'src/app/util/model/response-api';
import { LoginRequest } from '../model/login-request';
import { Usuario } from '../model/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {


  private receitaUrl: string = "https://estudoemvideo.acmesistemas.com.br/EstudoEmVideo/Conta";
  mostrarMenu : boolean = false;
  usuarioAutenticado: boolean = false;

  constructor(private httpClient: HttpClient, private router : Router) {

  }

  Login(token: string, login: string, senha: string): void
  {
    let usrs :  LoginRequest = new LoginRequest();
    usrs.Login = login;
    usrs.Senha= senha;

     this.httpClient.post<Usuario>(`${this.receitaUrl}/Login`,usrs,{
      headers: new HttpHeaders()
        .set('content-type','application/json')
        .set('Authorization','Bearer '+token)
    }).subscribe({
      next: (usuario: Usuario)=>{
        if(usuario != null){
          this.usuarioAutenticado = true;
          this.router.navigate(['/home']);
        }
        else{
        }
      }
    });
  }

  Add(token: string,usuario:Usuario): Observable<Usuario>
  {
    let usrs : Usuario = new Usuario();

    return this.httpClient.post<Response>(`${this.receitaUrl}/Add`,usrs,{
      headers: new HttpHeaders()
        .set('content-type','application/json')
        .set('Authorization','Bearer '+token)
    });
  }

  get UsuarioEstaAutenticado(){
    return this.usuarioAutenticado;
  }
}
