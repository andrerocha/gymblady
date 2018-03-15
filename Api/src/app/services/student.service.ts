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

    return this.http.get(this.BaseUrl + '/Student/GetallStudents');
  }

  GetById(id: number): Observable<any> {

    return this.http.get(this.BaseUrl + '/Student/GetStudentByIdStudent?idStudent=' + id);
  }

  Add(student: Student): Observable<any> {

    return this.http.post(this.BaseUrl + '/Student/AddStudent', student);
  }

  Update(student: Student): Observable<any> {

    return this.http.put(this.BaseUrl + '/Student/UpdateStudent', student);
  }

  Delete(id: number): Observable<any> {

    return this.http.delete(this.BaseUrl + '/Student/DeleteStudent?idStudent=' + id);
  }
}
