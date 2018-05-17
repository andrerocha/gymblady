import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from '../../base.component';
import { Router, ActivatedRoute } from '@angular/router';
import { StudentService } from '../../../services/student.service';
import { Student } from '../../../models/student';
import { KeyValuePair } from '../../../models/common/key-value-pair';
import { CoreService } from '../../../services/core.service';
import { StudentPhone } from '../../../models/studentPhone';
import { StudentAddress } from '../../../models/studentAddress';

@Component({
    selector: 'student',
    templateUrl: './student.component.html'
})
export class StudentComponent extends BaseComponent implements OnInit {
    
    public student: Student = new Student();
    private idStudent: number;
    public bloodTypes: KeyValuePair[];
    public studentAddresses: StudentAddress[];
    public studentPhones: StudentPhone[];

    constructor(private injector: Injector,        
                private studentService: StudentService,
                private route: ActivatedRoute,
                private router: Router,
                private coreService: CoreService) {
        super(injector)
    }

    ngOnInit() {

        this.GetUrlParams();
        this.GetStudent();
    }

    private GetUrlParams(): void {

        this.route.params.subscribe(result => {
            this.idStudent = +result['idStudent'];
        });
    }

    private GetAllBlodyTypes(): void {

        let errorMessage = 'Ocorreu um erro ao carregar os tipos sanguíneos.';

        this.coreService.GetAllBloodTypes().subscribe(result => {
            this.bloodTypes = result.json() as KeyValuePair[];
        }, error => {
            this.LoadingHelper.Hide();
            error = error.json();
            errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
            this.MessageHelper.ShowDanger(errorMessage);
        }, () => {
            this.LoadingHelper.Hide();
        });
    }

    private GetStudent(): void {

        if (this.idStudent && this.idStudent > 0) {

            this.LoadingHelper.Show();

            let errorMessage = 'Ocorreu um erro ao carregar o aluno.';

            this.studentService.GetStudentById(this.idStudent).subscribe(result => {
                this.student = result.json() as Student;
            }, error => {
                this.LoadingHelper.Hide();
                error = error.json();
                errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
                this.MessageHelper.ShowDanger(errorMessage);
            }, () => {
                this.SetStudentProperties();
            });
        } else {            
            this.SetStudentProperties();
        }
    }    

    private SetStudentProperties(): void {

        if (!this.idStudent || this.idStudent == 0) {

            this.student.bloodType = 0;
        }

        this.GetAllBlodyTypes();
    }

    public Save(): void {

        console.log(this.student);

        this.LoadingHelper.Show();

        let errorMessage = 'Ocorreu um erro ao salvar o aluno.';

        if (this.idStudent && this.idStudent > 0) {

            this.studentService.UpdateStudent(this.student).subscribe(result => {
                this.student = result.json() as Student;
            }, error => {
                this.LoadingHelper.Hide();
                error = error.json();
                errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
                this.MessageHelper.ShowDanger(errorMessage);
            }, () => {
                this.SaveCallBack();
            });            
        } else {

            this.studentService.AddStudent(this.student).subscribe(result => {
                this.student = result.json() as Student;
            }, error => {
                this.LoadingHelper.Hide();
                error = error.json();
                errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
                this.MessageHelper.ShowDanger(errorMessage);
            }, () => {
                this.SaveCallBack();
            });
        }
    }

    private SaveCallBack(): void {

        let successMessage = 'Aluno salvo com sucesso.';

        this.LoadingHelper.Hide();
        this.MessageHelper.ShowSuccess(successMessage);
        this.router.navigateByUrl('students');
    }
}