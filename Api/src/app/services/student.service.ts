import { Component, Inject, Injector, Injectable } from '@angular/core';
import { Http, RequestOptions } from '@angular/http';
import { BaseService } from './base.service';
import { Observable } from 'rxjs/Observable';
import { Student } from "../models/student";

@Injectable()
export class StudentService extends BaseService {

  constructor(injector: Injector, private http: Http) {

    super();
  }

  GetAllStudents(): Observable<any> {

    return this.http.get(this.BaseUrl + '/student/GetallStudents');
  }

  GetById(id: number): Observable<any> {

    return this.http.get(this.BaseUrl + '/student/GetById?id=' + id);
  }

  Add(student: Student): Observable<any> {

    return this.http.post(this.BaseUrl + '/student/add', student);
  }

  Update(student: Student): Observable<any> {

    return this.http.put(this.BaseUrl + '/student/update', student);
  }

  Delete(id: number): Observable<any> {

    return this.http.delete(this.BaseUrl + '/student/delete?id=' + id);
  }
}
