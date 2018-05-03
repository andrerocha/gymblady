import { Component, Injector } from '@angular/core';
import { AuthenticationService } from '../../services/authentication.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html'
})
export class AppComponent {

    public isAuthenticated: boolean = false;

    constructor(private authenticationService: AuthenticationService) {
    }

    get IsAuthenticate(): boolean {

        return this.authenticationService.IsAuthenticated;
    }

    ngOnInit() {
        
    }        
}