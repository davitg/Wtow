import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { TitleList } from './title/titleList.component'
import { TitleService } from './shared/titleService'


@NgModule({
    declarations: [
        AppComponent, TitleList
    ],
    imports: [
        BrowserModule, HttpClientModule
    ],
    providers: [TitleService],
    bootstrap: [AppComponent]
})
export class AppModule { }
