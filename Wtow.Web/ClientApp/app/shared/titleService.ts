import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core"
import { Observable } from "rxjs"
import "rxjs/add/operator/map"
import { Title } from "./title"
import { AccountService } from "./accountService";


@Injectable()
export class TitleService {

    constructor(private http: HttpClient, private accountService: AccountService) { }

    public titles: Title[] = [];

    loadTitles(): Observable<boolean> {
        return this.http.get("/api/Title/GetAll", {
            headers: new HttpHeaders().set("Authorization", "Bearer " + this.accountService.token)
        })
            .map((data: any[]) => {
                this.titles = data;
                return true;
            });

    }

    titleRate(titleId: number, raiting: number): Observable<boolean> {
        return this.http.post("/api/Title/Rate", { "titleId": titleId, "raiting": raiting }, {
            headers: new HttpHeaders().set("Authorization", "Bearer " + this.accountService.token)
        }
        )
            .map((data: any) => {
                return true;
            });

    }

}