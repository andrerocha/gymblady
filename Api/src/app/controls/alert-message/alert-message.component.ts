import { Component } from '@angular/core';

@Component({
    selector: 'alert-message',
    templateUrl: './alert-message.component.html',
    styleUrls: ['./alert-message.component.css']
})
export class AlertMessageComponent {

    public _show: boolean = false;
    public _message: string;
    public _class = 'alert-success';

    ShowSuccess(message: string): void {

        this._message = message;
        this._class = 'alert-success';
        this._show = true;
        this.CloseTimeout();
    }

    ShowWarning(message: string): void {

        this._message = message;
        this._class = 'alert-warning'
        this._show = true;
        this.CloseTimeout();
    }

    ShowDanger(message: string): void {

        this._message = message;
        this._class = 'alert-danger'
        this._show = true;
        this.CloseTimeout();
    }

    CloseTimeout(): void {

        setTimeout(() => {
            this.Close();
        }, 3000);
    }

    Close(): void {

        this._show = false;
    }
}