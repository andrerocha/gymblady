import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppModuleShared } from './app.module.shared';
import { AppComponent } from './components/app/app.component';
import { AlertMessageService } from "./services/controls/alert-message.service";
import { AuthenticationService } from "./services/authentication.service";
import { LoadingService } from "./services/controls/loading.service";
import { ModalService } from "./services/controls/modalservice";
import { StudentService } from "./services/student.service";

@NgModule({
    bootstrap: [ AppComponent ],
    imports: [
        BrowserModule,
        AppModuleShared        
    ],
    providers: [
        { provide: 'BASE_URL', useFactory: getBaseUrl },
        AlertMessageService,
        AuthenticationService,
        LoadingService,
        ModalService,
        StudentService
    ]
})
export class AppModule {
}

export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
