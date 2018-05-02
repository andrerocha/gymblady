import { Component } from '@angular/core';

@Component({
    selector: 'loading',
    templateUrl: './loading.component.html',
    styleUrls: ['./loading.component.css']
})
export class LoadingComponent {

    public _show: boolean = false;    
    
    Show(): void {

        this._show = true;
    }

    Hide(): void {

        this._show = false;
    }
}