import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'registro-materia';

  formRegsitroMateria = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3), Validators.pattern('^[A-Za-z]*$')]),
    cargahoraria: new FormControl('',[Validators.required, Validators.min(30), Validators.max(100)]),
    escola: new FormControl('', [Validators.required, Validators.pattern('^[A-Za-z]*$')]),
    professor: new FormControl('', [Validators.required]),
    materia: new FormControl('', Validators.required)
  })

  resetForm(){
    this.formRegsitroMateria.reset();
  }

  showForm(){
    console.log(this.formRegsitroMateria)
  }
}
