import { Component, OnInit } from '@angular/core';
import { IAccount } from '../iaccount';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { FormsModule} from '@angular/forms';
import { AccountService } from '../account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  account: IAccount = {
    email: null,
    passwordHash: null,
    username: null,
    role: 'freeUser'
  }
  postError = false;
  postErrorMessage = ''

  constructor(private router : Router, private accountService: AccountService) { }

  onBack(){
    this.router.navigate(['/']);
  }

  onSubmit(form: NgForm){
    if (form.valid) {
      this.accountService.createAccount(this.account).subscribe(message => {
        this.postError = true;
        this.postErrorMessage = `New account created!`;
        this.router.navigate(['/register/success']); 
      }, error => {
        console.log(`An error occured, Error: ${error.error}`);
        this.postError = error;
        this.postErrorMessage = error.error;
      });
    }
    else {
      this.postError = true;
      this.postErrorMessage = 'Fix your data and try again';
    }
  }

  ngOnInit() {
  }

}