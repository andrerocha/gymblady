import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from '../../base.component';
import { Router, ActivatedRoute } from '@angular/router';
import { StudentService } from '../../../services/student.service';
import { Student } from '../../../models/student';

@Component({
    selector: 'students',
    templateUrl: './students.component.html'
})
export class StudentsComponent extends BaseComponent implements OnInit {
    
    public students: Student[];

    constructor(private injector: Injector,        
                private studentService: StudentService,
                private route: ActivatedRoute,
                private router: Router) {
        super(injector)
    }

    ngOnInit() {
        
        this.GetStudents();
    }

    private GetStudents(): void {
        
        this.LoadingHelper.Show();

        let errorMessage = 'Ocorreu um erro ao carregar os alunos.';

        this.studentService.GetAllStudents().subscribe(result => {
            this.students = result.json() as Student[];
        }, error => {
            this.LoadingHelper.Hide();
            error = error.json();
            errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
            this.MessageHelper.ShowDanger(errorMessage);
        }, () => {
            this.LoadingHelper.Hide();
        });        
    }
}