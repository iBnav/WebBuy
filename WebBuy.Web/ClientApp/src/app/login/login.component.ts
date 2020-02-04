import { Component, OnInit } from "@angular/core";
import { User } from "../model/user";
import { Router, ActivatedRoute } from "@angular/router";
import { UserService } from "../services/user/user.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls:['./login.component.css']
})
export class LoginComponent implements OnInit {
    
  public user;
  public returnUrl: string;
  public responseMessage;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private userService:UserService) {
    
  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.user = new User();
  }

  entrar() {

    this.userService.verificarUsuario(this.user).subscribe(
      data => {
        this.responseMessage = null;
        var returnedUser: User;
        returnedUser = data;
        sessionStorage.setItem("autenticated", "1");
        sessionStorage.setItem("userId", (returnedUser.id).toString());
        if (this.returnUrl != null)
          this.router.navigate([this.returnUrl]);
        else
          this.router.navigate(["/"]);
      },
      err => {
        this.user = new User();
        this.responseMessage = err.error;
      }
    );
  }
}
