import { Component, AfterViewInit, ReflectiveInjector, Injector, OnInit, OnDestroy, Inject } from '@angular/core';

export abstract class BaseService {
    
    public _baseUrl: string = 'http://localhost:51442/api';

    get BaseUrl(): string {

        return this._baseUrl;
    }

    constructor() { }
}