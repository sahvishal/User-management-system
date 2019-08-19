import { Component, OnInit } from '@angular/core';
import { LoginService } from '../shared/login.service';
import { ILoginCredential } from './login-credentials';
import { first } from 'rxjs/operators';
import { Router } from '@angular/router';
//import { LoginService } from '../shared/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    constructor(private loginService: LoginService,
        private router: Router) { }

    _userName = '';
    get userName(): string {
        return this._userName;
    }
    set userName(value: string) {
        this._userName = value;
    }

    _password = '';
    get password(): string {
        return this._password;
    }
    set password(value: string) {
        this._password = value;
    }

    DoLogin(): void {
        if (this._userName && this._password) {
            let x: ILoginCredential = {
                userName: this._userName,
                password: this._password,
                Id: 0,
                IsDeleted: false
            }
            alert("hello, I am in component");
            this.loginService.DoLogin1(x).subscribe(
                data => {
                    console.log(data)
                },
                error => {
                    console.log(error);

                },
                () => alert("")
            )
        }
        
    }

  ngOnInit() {
  }

}
