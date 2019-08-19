import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, CanActivate, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ILoginCredential } from '../login/login-credentials';

@Injectable({
  providedIn: 'root'
})
export class LoginGuard implements CanActivate {
    currentUser1: ILoginCredential

    constructor(private router: Router) { }
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        this.currentUser1 = JSON.parse(localStorage.getItem('currentUser'));
        if (this.currentUser1.id == 1) {
            this.router.navigate(['/register']);
            return true;
        }
        return false;
    }
  
}
