import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn:'root'
})
export class RouteGuard implements CanActivate {
  
  constructor(private router: Router) {
      
    }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var autenticado = sessionStorage.getItem("autenticated");
    if (autenticado == "1") {
      return true;
    }

    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    return false;
  }
  
}
