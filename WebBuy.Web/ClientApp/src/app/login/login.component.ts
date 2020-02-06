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
  private ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private userService:UserService) {
    
  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.user = new User();
  }

  entrar() {
    this.ativar_spinner = true;
    this.userService.verificarUsuario(this.user).subscribe(
      data => {
        this.responseMessage = null;

        this.userService.user = data;
        
        //sessionStorage.setItem("userId", (returnedUser.id).toString());

        if (this.returnUrl != null)
          this.router.navigate([this.returnUrl]);
        else
          this.router.navigate(["/"]);
        this.ativar_spinner = false;
      },
      err => {
        this.user = new User();
        this.responseMessage = err.error;
        this.ativar_spinner = false;
      }
    );
  }
}
