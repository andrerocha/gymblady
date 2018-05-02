import { Injectable } from '@angular/core';
import { LoadingComponent } from '../../components/controls/loading/loading.component';

@Injectable()
export class LoadingService {

    private _loadingComponent: LoadingComponent;

    constructor() { }

    public LoadComponent(loadingComponent: LoadingComponent): void {

        this._loadingComponent = loadingComponent;
    }

    public Show(): void {

        this._loadingComponent.Show();
    }

    public Hide(): void {

        this._loadingComponent.Hide();
    }
}