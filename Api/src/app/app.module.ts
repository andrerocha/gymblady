import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { AlertMessageComponent } from "./controls/alert-message/alert-message.component";
import { AutoCompleteComponent } from "./controls/auto-complete/auto-complete.component";
import { LoadingComponent } from "./controls/loading/loading.component";
import { ModalComponent } from "./controls/modal/modal.component";
import { PagerComponent } from "./controls/pager/pager.component";
import { MenuComponent } from "./menu/menu.component";
import { StudentsComponent } from "./pages/students/students.component";

import { StudentService } from "./services/student.service";
import { StudentComponent } from "./pages/students/student.component";

const appRoutes: Routes = [  
  { path: 'dashboard', component: DashboardComponent },  
  { path: 'students', component: StudentsComponent },
  { path: 'student', component: StudentComponent },
  { path: 'student/:id', component: StudentComponent }, 
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  //{ path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    AlertMessageComponent,
    AutoCompleteComponent,
    LoadingComponent,
    ModalComponent,
    PagerComponent,
    MenuComponent,
    StudentsComponent,
    StudentComponent
  ],
  imports: [
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    ),
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [
    StudentService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
