import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { TitleList } from './title/titleList.component';
import { UserTitles } from './user/userTitles.component';
import { TitleService } from './shared/titleService';

import { RouterModule } from "@angular/router";

let routes = [
    { path: "", component: TitleList },
    { path: "/mytitles", component: UserTitles }
];

@NgModule({
    declarations: [
        AppComponent,
        TitleList,
        UserTitles
    ],
    imports: [
        BrowserModule,
        HttpClientModule,
        RouterModule.forRoot(routes, {
            useHash: true,
            enableTracing: false,
            
        })

    ],
    providers: [TitleService],
    bootstrap: [AppComponent]
})
export class AppModule { }
