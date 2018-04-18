import { Component } from '@angular/core';
import { AccountService } from '../shared/accountService';
import { Router } from '@angular/router';


@Component({
    selector: "login",
    templateUrl: "login.component.html"

})
export class Login {

    constructor(private accountService: AccountService, private router: Router, ) { }

    errorMessage: string = "";

    public creds = {
        username: "",
        passwprd: ""
    };


    onLogin() {
        this.accountService.login(this.creds)
            .subscribe(
            success => {
                if (success) {
                    this.router.navigate(["/"]);
                }
            },
            error => {
                this.errorMessage = "Failed to login"
            })
    }
}