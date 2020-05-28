import { Component, OnInit } from '@angular/core';
import { IAccount } from '../iaccount';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  account: IAccount = {
    Email: null,
    Password: null,
    Username: null,
    Role: null
  }
  postError = false;
  postErrorMessage = ''
  
  constructor(private router : Router) { }

  onBack(){
    this.router.navigate(['/']);
  }

  ngOnInit() {
  }

}
