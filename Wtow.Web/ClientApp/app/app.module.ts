import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TitleList } from './title/titleList.component';
import { UserTitles } from './user/userTitles.component';

import { TitleService } from './shared/titleService';
import { AccountService } from './shared/accountService';

import { RouterModule } from "@angular/router";

let routes = [
    { path: "", component: HomeComponent },
    { path: "mytitles", component: UserTitles }
];

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
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
    providers: [AccountService, TitleService],
    bootstrap: [AppComponent]
})
export class AppModule { }
