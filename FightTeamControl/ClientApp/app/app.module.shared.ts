import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { DashboardComponent } from "./components/pages/dashboard/dashboard.component";
import { LoginComponent } from "./components/pages/login/login.component";
import { StudentsComponent } from "./components/pages/students/students.component";
import { MasterComponent } from "./components/pages/master/master.component";
import { AlertMessageComponent } from "./components/controls/alert-message/alert-message.component";
import { AutoCompleteComponent } from "./components/controls/auto-complete/auto-complete.component";
import { LoadingComponent } from "./components/controls/loading/loading.component";
import { ModalComponent } from "./components/controls/modal/modal.component";
import { PagerComponent } from "./components/controls/pager/pager.component";
import { StudentComponent } from './components/pages/students/student.component';
import { LoginRouteGuard } from './components/route/login-route-guard';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        LoginComponent,
        MasterComponent,
        DashboardComponent,
        StudentsComponent,
        StudentComponent,
        AlertMessageComponent,
        AutoCompleteComponent,
        LoadingComponent,
        ModalComponent,
        PagerComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'login', component: LoginComponent },
            { path: 'dashboard', component: DashboardComponent, canActivate: [LoginRouteGuard] },
            { path: 'students', component: StudentsComponent, canActivate: [LoginRouteGuard] },
            { path: 'student', component: StudentComponent, canActivate: [LoginRouteGuard] },
            { path: 'student/:idStudent', component: StudentComponent, canActivate: [LoginRouteGuard] },
            { path: '**', redirectTo: 'dashboard' }
        ])
    ]
})
export class AppModuleShared {
}
