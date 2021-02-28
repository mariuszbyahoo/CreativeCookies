import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login-dialog-content',
  templateUrl: './login-dialog-content.component.html',
  styleUrls: ['./login-dialog-content.component.css']
})
export class LoginDialogContentComponent implements OnInit {
  loginForm: FormGroup
  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      email: '',
      login: ''
    })
  }

}
