import { Component, AfterViewInit, ReflectiveInjector, Injector, OnInit, OnDestroy, Inject } from '@angular/core';

export abstract class BaseService {
    
    public _baseUrl: string = 'http://localhost:62790/api';

    get BaseUrl(): string {

        return this._baseUrl;
    }

    constructor() { }
}