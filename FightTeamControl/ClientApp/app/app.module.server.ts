import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { AppModuleShared } from './app.module.shared';
import { AppComponent } from './components/app/app.component';
import { AlertMessageService } from "./services/controls/alert-message.service";
import { AuthenticationService } from "./services/authentication.service";
import { LoadingService } from "./services/controls/loading.service";
import { ModalService } from "./services/controls/modalservice";
import { StudentService } from "./services/student.service";
import { LoginRouteGuard } from './components/route/login-route-guard';
import { CoreService } from './services/core.service';

@NgModule({
    bootstrap: [ AppComponent ],
    imports: [
        ServerModule,
        AppModuleShared
    ],
    providers: [
        AlertMessageService,
        AuthenticationService,
        LoadingService,
        ModalService,
        StudentService,
        LoginRouteGuard,
        CoreService
    ]
})
export class AppModule {
}
