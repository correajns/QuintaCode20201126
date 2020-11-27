import { Component, OnInit } from '@angular/core';
import { Usuario } from '../usuario';
import { UsuarioService } from '../usuario.service';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {

  usuario: Usuario;
  usuarios : Usuario[] = [];
  constructor(private usuarioService : UsuarioService) { }

  ngOnInit(): void {
    this.usuarioService.getUsuarios().toPromise().then(res => this.usuarios = res);
  }
  IncluirUsuario() : void
  {
    let  user :  Usuario ={
      cpf : "121321321",
      nome : "novo nome",
      id : 1,
      dataInclusao :  Date.now.toString(),
      dataNasc :  "25/05/1985",
      email : "correajns@gmail.com",
      rg  : "28297058-x"
 
     }
     this.usuarios.push(user);
     this.usuarioService.inserirusuario(user);
  }

  ExcluirUsuario() : void
  {
    this.usuarios.pop();
  }

}
