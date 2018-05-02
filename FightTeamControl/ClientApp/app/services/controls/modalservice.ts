import { Injectable } from '@angular/core';
import { ModalComponent } from '../../components/controls/modal/modal.component';
import { ModalSize } from '../../components/controls/modal/enum/modal-size';

@Injectable()
export class ModalService {

    private _modalComponent: ModalComponent;

    constructor() { }

    public LoadComponent(modalComponent: ModalComponent): void {

        this._modalComponent = modalComponent;
    }

    Open(title: string, message: string, size?: ModalSize, callBack?: any, context?: any, confirmMessage?: string, cancelMessage?: string): void {

        this._modalComponent.Open(title, message, size, callBack, context, confirmMessage, cancelMessage);
    }
}