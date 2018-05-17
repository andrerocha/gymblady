import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from '../../base.component';
import { Router, ActivatedRoute } from '@angular/router';
import { StudentService } from '../../../services/student.service';
import { Student } from '../../../models/student';
import { ModalSize } from '../../controls/modal/enum/modal-size';

@Component({
    selector: 'students',
    templateUrl: './students.component.html'
})
export class StudentsComponent extends BaseComponent implements OnInit {
    
    public students: Student[];
    private student: Student;

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

    public RedirectToStudent(student: Student): void {

        this.router.navigateByUrl('student/' + student.idStudent);
    }

    public DeleteStudentConfirm(student: Student): void {

        this.student = student;

        this.ModalHelper.Open('Aluno', 'Deseja realmente excluir o aluno?', ModalSize.Medium, this.DeleteStudent, this, 'Sim', 'Não');
    }

    private DeleteStudent(context: StudentsComponent): void {

        context.LoadingHelper.Show();

        let errorMessage = 'Ocorreu um erro ao excluir o aluno.';

        context.studentService.DeleteStudent(context.student.idStudent).subscribe(result => {
            null
        }, error => {
            context.LoadingHelper.Hide();
            error = error.json();
            errorMessage = error && error.errorMessages ? error.errorMessages : errorMessage;
            context.MessageHelper.ShowDanger(errorMessage);
        }, () => {
            context.DeleteStudentCallBack();
        });  
    }

    private DeleteStudentCallBack(): void {

        let successMessage = 'Aluno excluído com sucesso.';

        this.LoadingHelper.Hide();
        this.MessageHelper.ShowSuccess(successMessage);
        this.GetStudents();
    }
}