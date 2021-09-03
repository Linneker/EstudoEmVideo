import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UploadService {

  url : string = "https://localhost:5001/";
  constructor() { }


}
