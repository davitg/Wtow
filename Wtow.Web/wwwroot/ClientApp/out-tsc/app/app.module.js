"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var app_component_1 = require("./app.component");
var home_component_1 = require("./home/home.component");
var titleList_component_1 = require("./title/titleList.component");
var userTitles_component_1 = require("./user/userTitles.component");
var login_component_1 = require("./login/login.component");
var titleService_1 = require("./shared/titleService");
var accountService_1 = require("./shared/accountService");
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var routes = [
    { path: "", component: home_component_1.HomeComponent },
    { path: "mytitles", component: userTitles_component_1.UserTitles },
    { path: "login", component: login_component_1.Login }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                home_component_1.HomeComponent,
                titleList_component_1.TitleList,
                userTitles_component_1.UserTitles,
                login_component_1.Login
            ],
            imports: [
                platform_browser_1.BrowserModule,
                http_1.HttpClientModule,
                forms_1.FormsModule,
                router_1.RouterModule.forRoot(routes, {
                    useHash: true,
                    enableTracing: false,
                })
            ],
            providers: [accountService_1.AccountService, titleService_1.TitleService],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map