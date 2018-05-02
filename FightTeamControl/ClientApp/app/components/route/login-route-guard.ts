import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AuthenticationService } from '../../services/authentication.service';

@Injectable()
export class LoginRouteGuard implements CanActivate {

    constructor(private _router: Router,
                private authenticationService: AuthenticationService) {
    }   

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {        

        if (this.authenticationService.IsAuthenticated) {
            return true;
        }

        this._router.navigate(['/login']);
        return false;
    }
}