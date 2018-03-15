import { Component, OnInit } from '@angular/core';
import { Http } from "@angular/http";
import { Params, ActivatedRoute, Router } from "@angular/router";

import { Student } from "../../models/student";
import { StudentService } from "../../services/student.service";

@Component({
  selector: 'student',
  templateUrl: './student.component.html'
})
export class StudentComponent implements OnInit {

  private idStudent: number;
  public student = new Student();

  constructor(private _httpService: Http,
              private studentService: StudentService,
              private route: ActivatedRoute,
              private router: Router) {
  }  

  ngOnInit() {

    this.GetUrlParams();
    this.GetStudent();
  }

  GetUrlParams(): void {

    this.route.params.forEach((params: Params) => {
      this.idStudent = +params['id'];
    });
  }

  GetStudent(): void {

    if (this.idStudent && this.idStudent > 0) {     

      let errorMessage = 'Ocorreu um erro ao carregar o aluno.';

      this.studentService.GetById(this.idStudent).subscribe(result => {
        this.student = result.json() as Student;
      }, error => {
        alert(errorMessage);
      }, () => null);
    }
  }

  Save(): void {  

    let errorMessage = 'Ocorreu um erro ao salvar o aluno.';
    let successMessage = 'Aluno salvo com sucesso.';

    if (this.idStudent && this.idStudent > 0) {

      this.studentService.Update(this.student).subscribe(result => {
        this.student = result.json() as Student;
      }, error => {
        alert(errorMessage);
      }, () => {
        this.RedirectToStudents();
      });

    } else {

      this.studentService.Add(this.student).subscribe(result => {
        this.student = result.json() as Student;
      }, error => {
        alert(errorMessage);
      },
        () => {
          this.RedirectToStudents();
        });
    }
  }

  RedirectToStudents() {

    this.router.navigateByUrl('/students');
  }
}
