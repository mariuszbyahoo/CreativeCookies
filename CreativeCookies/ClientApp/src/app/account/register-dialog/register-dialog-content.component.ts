import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { IAccountForm } from '../register/IAccountForm';

@Component({
  selector: 'app-register-dialog-content',
  templateUrl: './register-dialog-content.component.html',
  styleUrls: ['./register-dialog-content.component.css']
})
export class RegisterDialogContentComponent implements OnInit {
  registerFrom: FormGroup;
  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.registerFrom = this.fb.group({
      email: '',
      passwordHash: '',
      confirmPassword: '',
      DataProcessingConsent: false
    })
  }

}
