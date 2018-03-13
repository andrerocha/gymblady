import { Component, OnInit } from '@angular/core';
import { Http } from "@angular/http";

@Component({
  selector: 'dashboard',
  templateUrl: './dashboard.component.html'
})
export class DashboardComponent implements OnInit {

  constructor(private _httpService: Http) { }

  apiValues: any[] = [];

  ngOnInit() {

    this._httpService.get('/api/city/getallcities').subscribe(values => {

      this.apiValues = values.json() as any[];
    });
  }
}
