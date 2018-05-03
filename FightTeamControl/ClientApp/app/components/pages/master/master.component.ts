import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { BaseComponent } from '../../base.component';
import { LoadingComponent } from '../../controls/loading/loading.component';
import { AlertMessageComponent } from '../../controls/alert-message/alert-message.component';
import { ModalComponent } from '../../controls/modal/modal.component';
import { LoadingService } from '../../../services/controls/loading.service';
import { AlertMessageService } from '../../../services/controls/alert-message.service';
import { ModalService } from '../../../services/controls/modalservice';

@Component({
    selector: 'master',
    templateUrl: './master.component.html',
    styleUrls: ['master.component.css']
})
export class MasterComponent extends BaseComponent implements OnInit {

    @ViewChild('loading') _loadingComponent: LoadingComponent;
    @ViewChild('alertMessage') _alertMessageComponent: AlertMessageComponent;
    @ViewChild('modal') _modalComponent: ModalComponent;    

    get Email(): string {

        return 'teste@teste.com.br';
    }

    get UrlImage(): string {

        return '';
    }

    constructor(private injector: Injector,
                private loadingService: LoadingService,
                private alertMessageService: AlertMessageService,
                private modalService: ModalService) {
        super(injector)
    }

    ngOnInit() {

        this.loadingService.LoadComponent(this._loadingComponent);
        this.alertMessageService.LoadComponent(this._alertMessageComponent);
        this.modalService.LoadComponent(this._modalComponent);
    }

    public LogOut(): void {
        
    }
}