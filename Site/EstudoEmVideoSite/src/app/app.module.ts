import { AppRoutingModule } from './app-routing.module';
import { LoginModule } from './login/login.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AutorizacaoApiService } from './autorizacao-api/autorizacao-api/autorizacao-api.service';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ModalModule.forRoot(),
    LoginModule
  ],
  providers: [AutorizacaoApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
