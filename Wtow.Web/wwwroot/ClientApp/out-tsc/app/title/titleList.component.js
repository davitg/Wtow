"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var titleService_1 = require("../shared/titleService");
var accountService_1 = require("../shared/accountService");
var router_1 = require("@angular/router");
var TitleList = /** @class */ (function () {
    function TitleList(titleService, accountService, router) {
        this.titleService = titleService;
        this.accountService = accountService;
        this.router = router;
        this.titles = [];
        this.titles = titleService.titles;
    }
    TitleList.prototype.ngOnInit = function () {
        var _this = this;
        this.titleService.loadTitles()
            .subscribe(function (success) {
            if (success) {
                _this.titles = _this.titleService.titles;
            }
        });
    };
    TitleList.prototype.onTitleRate = function (title) {
        if (this.accountService.loginRequired) {
            this.router.navigate(["login"]);
        }
        else {
            this.titleService.titleRate(title.titleId, title.userRaiting)
                .subscribe(function (success) { }, function (error) { });
        }
    };
    TitleList = __decorate([
        core_1.Component({
            selector: "title-list",
            templateUrl: "titleList.component.html",
            styleUrls: ["titleList.component.css"]
        }),
        __metadata("design:paramtypes", [titleService_1.TitleService, accountService_1.AccountService, router_1.Router])
    ], TitleList);
    return TitleList;
}());
exports.TitleList = TitleList;
//# sourceMappingURL=titleList.component.js.map