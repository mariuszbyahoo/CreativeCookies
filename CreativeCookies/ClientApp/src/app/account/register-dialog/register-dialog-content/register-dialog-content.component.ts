import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { AccountService } from '../../account.service';
import { IAccount } from '../../iaccount';

@Component({
  selector: 'app-register-dialog-content',
  templateUrl: './register-dialog-content.component.html',
  styleUrls: ['./register-dialog-content.component.css']
})
export class RegisterDialogContentComponent implements OnInit {
  registerForm: FormGroup;
  account: IAccount = {
    email: null,
    passwordHash: null,
    username: null,
    role: 'freeUser'
  }
  constructor(private fb: FormBuilder, private accountService: AccountService) { }
  ngOnInit(): void {
    this.registerForm = this.fb.group({
      email: '',
      passwordHash: '',
      confirmPassword: '',
      DataProcessingConsent: false
    })
  }

  onSubmit() {

    if (this.registerForm.valid) {
      if (this.registerForm.get('passwordHash').value === this.registerForm.get('confirmPassword').value) {
        this.account.email = this.registerForm.get('email').value;
        this.account.username = this.account.email;
        this.account.passwordHash = this.registerForm.get('passwordHash').value;
        this.accountService.createAccount(this.account).subscribe(message => {
          console.log('api succeed and returned:');
          console.log(message);
        }, error => {
          console.log(`An error occured, Error: ${error.error}`);
        });
      }
    }
    else {
      console.log('Fix your data and try again');
    }
  }
}
