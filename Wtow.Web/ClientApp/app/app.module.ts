import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { TitleList } from './title/titleList.component';
import { UserTitles } from './user/userTitles.component';
import { Login } from './login/login.component';

import { TitleService } from './shared/titleService';
import { AccountService } from './shared/accountService';

import { RouterModule } from "@angular/router";
import { FormsModule } from "@angular/forms";


let routes = [
    { path: "", component: HomeComponent },
    { path: "mytitles", component: UserTitles },
    { path: "login", component: Login }
];

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        TitleList,
        UserTitles,
        Login
    ],
    imports: [
        BrowserModule,
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot(routes, {
            useHash: true,
            enableTracing: false,
            
        })
    ],
    providers: [AccountService, TitleService],
    bootstrap: [AppComponent]
})
export class AppModule { }
