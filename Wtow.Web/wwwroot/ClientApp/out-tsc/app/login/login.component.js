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
var accountService_1 = require("../shared/accountService");
var router_1 = require("@angular/router");
var Login = /** @class */ (function () {
    function Login(accountService, router) {
        this.accountService = accountService;
        this.router = router;
        this.errorMessage = "";
        this.creds = {
            username: "",
            passwprd: ""
        };
    }
    Login.prototype.onLogin = function () {
        var _this = this;
        this.accountService.login(this.creds)
            .subscribe(function (success) {
            if (success) {
                _this.router.navigate(["/"]);
            }
        }, function (error) {
            _this.errorMessage = "Failed to login";
        });
    };
    Login = __decorate([
        core_1.Component({
            selector: "login",
            templateUrl: "login.component.html"
        }),
        __metadata("design:paramtypes", [accountService_1.AccountService, router_1.Router])
    ], Login);
    return Login;
}());
exports.Login = Login;
//# sourceMappingURL=login.component.js.map