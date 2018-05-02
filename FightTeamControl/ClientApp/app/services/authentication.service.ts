import { Component, AfterViewInit, ReflectiveInjector, Injector, OnInit, OnDestroy, Inject, Injectable } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http } from "@angular/http";
import { BaseService } from "./base.service";
import { Observable } from "rxjs/Observable";

@Injectable()
export class AuthenticationService extends BaseService {

    //public login: Login = new Login();
    //public driver: Driver = new Driver();

    constructor() {
        super();
    }

    get IsAuthenticated(): boolean {

        //return this.login && this.login.codLogin > 0;
        return true;
    }

    //get LoggedUser(): Login {

    //    return this.login;
    //}

    //get Driver(): Driver {

    //    return this.driver;
    //}

    //public Logout(): void {

    //    this.login = new Login();
    //    this.headerService.Hide();
    //    this.navMenuService.Hide();
    //}    

    //public Authenticate(login: Login): void {

        //this.login = login;
        //this.headerService.Show();
        //this.navMenuService.Show();
        //this.GetDriver();
    //}

    //private GetDriver(): void {

    //    let errorMessage = 'Ocorreu um erro ao carregar o Motorista.';

    //    this.driverService.GetByIdLogin(this.login.codLogin).subscribe(result => {
    //        this.driver = result.json().data as Driver;
    //    }, error => {
    //        error = error.json();
    //        errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
    //        console.log(errorMessage);
    //    }, () => {
           
    //    });
    //}
}