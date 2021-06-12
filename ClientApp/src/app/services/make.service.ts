import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MakeService {

  constructor(private http: HttpClient) {
  }

  getMakes(){
    return this.http.get('https://localhost:3001/api/makes');
  }
}
