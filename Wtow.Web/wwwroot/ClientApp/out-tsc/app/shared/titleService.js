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
var http_1 = require("@angular/common/http");
var core_1 = require("@angular/core");
require("rxjs/add/operator/map");
var accountService_1 = require("./accountService");
var TitleService = /** @class */ (function () {
    function TitleService(http, accountService) {
        this.http = http;
        this.accountService = accountService;
        this.titles = [];
    }
    TitleService.prototype.loadTitles = function () {
        var _this = this;
        return this.http.get("/api/Title/GetAll", {
            headers: new http_1.HttpHeaders().set("Authorization", "Bearer " + this.accountService.token)
        })
            .map(function (data) {
            _this.titles = data;
            return true;
        });
    };
    TitleService.prototype.titleRate = function (titleId, raiting) {
        return this.http.post("/api/Title/Rate", { "titleId": titleId, "raiting": raiting }, {
            headers: new http_1.HttpHeaders().set("Authorization", "Bearer " + this.accountService.token)
        })
            .map(function (data) {
            return true;
        });
    };
    TitleService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient, accountService_1.AccountService])
    ], TitleService);
    return TitleService;
}());
exports.TitleService = TitleService;
//# sourceMappingURL=titleService.js.map