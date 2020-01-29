import { Component } from "@angular/core";
import { User } from "../model/user";
import { Router } from "@angular/router";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls:['./login.component.css']
})
export class LoginComponent {
  public user;

  constructor(private router: Router) {
    this.user = new User();
  }

  entrar() {
    sessionStorage.setItem('autenticated', "1");

  }
}
