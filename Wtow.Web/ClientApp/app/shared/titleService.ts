import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core"
import { Observable } from "rxjs"
import "rxjs/add/operator/map"
import { Title } from "./title"


@Injectable()
export class TitleService  {

    constructor(private http: HttpClient) { }

    public titles : Title[] = [];

    loadTitles(): Observable<boolean> {
        return this.http.get("/api/title")
            .map((data: any[]) => {
                this.titles = data;
                return true;
            });
		
    }
}