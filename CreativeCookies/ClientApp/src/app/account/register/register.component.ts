import { Component, OnInit } from '@angular/core';
import { IAccount } from '../iaccount';

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
  
  constructor() { }

  ngOnInit() {
  }

}
