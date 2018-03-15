import { Component, OnInit } from '@angular/core';
import { Http } from "@angular/http";
import { Router } from "@angular/router";

import { Student } from "../../models/student";

import { StudentService } from "../../services/student.service";


@Component({
  selector: 'students',
  templateUrl: './students.component.html'
})
export class StudentsComponent implements OnInit {

  constructor(private _httpService: Http,
              private _studentService: StudentService,
              private router: Router) {
  }

  public students: Student[] = [];

  ngOnInit() {

    this._studentService.GetAllStudents().subscribe(values => {

      this.students = values.json() as Student[];
    });
  }

  public RedirectToEdit(student: Student): void {

    console.log(student);

    if (student && student.idStudent > 0) {
      this.router.navigateByUrl('/student/' + student.idStudent);
    }
  }
}
