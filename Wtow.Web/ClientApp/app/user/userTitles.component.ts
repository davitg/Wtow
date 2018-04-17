import { Component, OnInit } from "@angular/core";
import { TitleService } from "../shared/titleService";
import { Title, Rating } from "../shared/title"

@Component({
    selector: "user-titles",
    templateUrl: "userTitles.component.html",
    styleUrls: ["userTitles.component.css"] 
})
export class UserTitles implements OnInit {
    constructor(private titleService: TitleService) {
        this.titles = titleService.titles
    }

    public titles: Title[] = [];

    ngOnInit(): void {
        this.titleService.loadTitles()
            .subscribe(success => {
                if (success) {
                    this.titles = this.titleService.titles;
                }
            });
    }
}