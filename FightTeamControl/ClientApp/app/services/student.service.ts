import { Component, Inject, Injector, Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { BaseService } from './base.service';

import { Student } from '../models/student';

@Injectable()
export class StudentService extends BaseService {

    constructor(injector: Injector, private http: Http) {

        super();
    }

    GetAll(): Observable<any> {

        let url = this.BaseUrl + '/Student/GetAll';        

        return this.http.get(url);
    }

    GetById(id: number): Observable<any> {

        return this.http.get(this.BaseUrl + '/Student/GetById?id=' + id);
    }

    GetByIdUser(idUser: number): Observable<any> {

        return this.http.get(this.BaseUrl + '/Student/GetByIdUsuario?id=' + idUser);
    }

    GetByIdDriver(idDriver: number): Observable<any> {

        return this.http.get(this.BaseUrl + '/Student/GetByIdMotorista?id=' + idDriver);
    }

    GetByIdCompany(idCompany: number): Observable<any> {

        return this.http.get(this.BaseUrl + '/Student/GetByIdEmpresa?id=' + idCompany);
    }

    Add(student: Student): Observable<any> {    

        return this.http.post(this.BaseUrl + '/Student/Add', student);
    }

    Update(student: Student): Observable<any> {

        return this.http.put(this.BaseUrl + '/Student/Update', student);
    }

    Delete(id: number): Observable<any> {

        return this.http.delete(this.BaseUrl + '/Student/Delete?id=' + id);
    }
}