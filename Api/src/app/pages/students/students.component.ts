import { Component, OnInit } from '@angular/core';
import { Http } from "@angular/http";

@Component({
  selector: 'students',
  templateUrl: './students.component.html'
})
export class StudentsComponent implements OnInit {

  constructor(private _httpService: Http) { }

  sudents: any[] = [];

  ngOnInit() {

    this._httpService.get('/api/student/getallstudents').subscribe(values => {

      this.sudents = values.json() as any[];
    });
  }
}
