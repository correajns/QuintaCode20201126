import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from './usuario';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private http: HttpClient) { }

  api_url :string = 'https://localhost:5001/Usuario';

  getUsuarios(): Observable<any>{
    return this.http.get<Usuario[]>(this.api_url);
  }
  inserirusuario(user : Usuario): void
  {
     this.http.post(this.api_url,user);
  }
}
