import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core"
import { Observable } from "rxjs"
import "rxjs/add/operator/map"
import { Title } from "./title"


@Injectable()
export class AccountService  {

    constructor(private http: HttpClient) { }

    public token: string = "";
    private tokenExpiration: Date;

    public get loginRequired(): boolean {
        return this.token.length == 0 || this.tokenExpiration > new Date();
    }

    login(creds): Observable<boolean> {
        return this.http.post("/account/CreateToken", creds)
            .map((data: any) => {
                this.token = data.token,
                this.tokenExpiration = data.expiration
                return true;
            });

    }

}