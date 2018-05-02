import { Component, AfterViewInit, ReflectiveInjector, Injector, OnInit, OnDestroy, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AlertMessageService } from '../services/controls/alert-message.service';
import { ModalService } from "../services/controls/modalservice";
import { LoadingService } from "../services/controls/loading.service";

export abstract class BaseComponent {

    public _modalService: ModalService;
    public _loadingService: LoadingService;
    public _alertMessage: AlertMessageService;

    get ModalHelper(): ModalService {

        return this._modalService;
    }

    get LoadingHelper(): LoadingService {

        return this._loadingService;
    }

    get MessageHelper(): AlertMessageService {

        return this._alertMessage;
    }


    constructor(injector: Injector) {

        this._modalService = injector.get(ModalService);
        this._loadingService = injector.get(LoadingService);
        this._alertMessage = injector.get(AlertMessageService);
    }
}