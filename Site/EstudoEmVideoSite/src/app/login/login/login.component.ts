import { Component, OnInit } from '@angular/core';
import { LoginRequest } from 'src/app/usuario/model/login-request';
import { Router } from '@angular/router';

@Component({
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  login : LoginRequest = new LoginRequest()
  constructor() { }

  ngOnInit(): void {
  }

  Login():void{

  }
}
