import { Injectable } from '@angular/core';
import { AlertMessageComponent } from '../../components/controls/alert-message/alert-message.component';

@Injectable()
export class AlertMessageService {

    private _alertComponent: AlertMessageComponent;

    constructor() { }

    public LoadComponent(alertComponent: AlertMessageComponent): void {

        this._alertComponent = alertComponent;
    }

    ShowSuccess(message: string): void {

        this._alertComponent.ShowSuccess(message);
    }

    ShowWarning(message: string): void {

        this._alertComponent.ShowWarning(message);
    }

    ShowDanger(message: string): void {

        this._alertComponent.ShowDanger(message);
    }
}