import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { User } from "../../model/user";

@Injectable({
  providedIn: "root"
})
export class UserService {
  private baseURL: string;
  private _user: User;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  get user(): User {
    let user_json = sessionStorage.getItem("autenticated");
    this._user = JSON.parse(user_json);
    return this._user;
  }
  set user(user: User) {
    sessionStorage.setItem("autenticated", JSON.stringify(user));
    this._user = user;
  }

  public user_autenticated(): boolean {
    return this._user != null && this._user.email != "" && this._user.senha != "";
  }

  public clear_user() {
    sessionStorage.removeItem("autenticated");
    this._user = null;
  }

  public verificarUsuario(user: User): Observable<User> {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: user.email,
      senha: user.senha
    }

    return this.http.post<User>(this.baseURL + "api/User/VerificarUsuario", body, { headers });
  }
}
