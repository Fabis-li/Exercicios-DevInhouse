import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  feedBack: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.feedBack = formBuilder.group({
      email: this.formBuilder.control(''),
      nome: this.formBuilder.control(''),
      sobrenome: this.formBuilder.control(''),
      mensagem: this.formBuilder.control('')
   })

  }

 

}
