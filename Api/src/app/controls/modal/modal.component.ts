import { Component } from '@angular/core';
import { ModalSize } from "./enum/modal-size";

@Component({
    selector: 'modal',
    templateUrl: './modal.component.html',
    styleUrls: ['./modal.component.css']
})
export class ModalComponent {

    public _show: boolean = false;
    public _title: string;
    public _message: string;
    public _class: string = 'modal-lg';
    public _callBack: any;
    public _context: any;
    public _confirmMessage: string;
    public _cancelMessage: string;    

    Open(title: string, message: string, size?: ModalSize, callBack?: any, context?: any, confirmMessage?: string, cancelMessage?: string): void {

        this._title = title;
        this._message = message;

        if (size) {
            this._class = this.GetSizeClass(size);
        }

        if (callBack) {
            this._callBack = callBack;
        }

        if (context) {
            this._context = context;
        }

        if (confirmMessage) {
            this._confirmMessage = confirmMessage;
        }

        if (cancelMessage) {
            this._cancelMessage = cancelMessage;
        }

        this._show = true;
    }

    Close(): void {

        this._show = false;
    }

    Confirm(): void {

        if (this._callBack) {

            this._callBack(this._context);
        }

        this._show = false;
    }

    GetSizeClass(size: ModalSize): string {

        let sizeClass = '';

        switch (size) {

            case ModalSize.Small:
                sizeClass = 'modal-sm';
                break;

            case ModalSize.Medium:
                sizeClass = 'modal-md';
                break;

            case ModalSize.Large:
                sizeClass = 'modal-lg';
                break;
        }

        return sizeClass;
    }
}