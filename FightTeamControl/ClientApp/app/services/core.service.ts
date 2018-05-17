import { Component, Inject, Injector, Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { BaseService } from './base.service';

@Injectable()
export class CoreService extends BaseService {

    constructor(injector: Injector, private http: Http) {

        super();
    }

    GetAllBloodTypes(): Observable<any> {

        let url = this.BaseUrl + '/Core/GetAllBloodTypes';        

        return this.http.get(url);
    }
}