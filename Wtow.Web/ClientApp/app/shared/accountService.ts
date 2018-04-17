import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core"
import { Observable } from "rxjs"
import "rxjs/add/operator/map"
import { Title } from "./title"


@Injectable()
export class AccountService  {

    constructor(private http: HttpClient) { }

    private token: string = "";
    private tokenExpiration: Date;

    public get loginRequired(): boolean {
        return this.token.length == 0 || this.tokenExpiration > new Date();
    }
    
}