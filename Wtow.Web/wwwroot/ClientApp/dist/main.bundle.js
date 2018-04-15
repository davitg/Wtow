webpackJsonp(["main"],{

/***/ "./ClientApp/$$_lazy_route_resource lazy recursive":
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncatched exception popping up in devtools
	return Promise.resolve().then(function() {
		throw new Error("Cannot find module '" + req + "'.");
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./ClientApp/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./ClientApp/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<h2> Hello {{title}} </h2>\r\n<title-list></title-list>"

/***/ }),

/***/ "./ClientApp/app/app.component.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'Title List';
    }
    AppComponent = __decorate([
        core_1.Component({
            selector: 'wtow-app',
            template: __webpack_require__("./ClientApp/app/app.component.html"),
            styles: []
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;


/***/ }),

/***/ "./ClientApp/app/app.module.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = __webpack_require__("./node_modules/@angular/platform-browser/esm5/platform-browser.js");
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var http_1 = __webpack_require__("./node_modules/@angular/common/esm5/http.js");
var app_component_1 = __webpack_require__("./ClientApp/app/app.component.ts");
var titleList_component_1 = __webpack_require__("./ClientApp/app/title/titleList.component.ts");
var titleService_1 = __webpack_require__("./ClientApp/app/shared/titleService.ts");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent, titleList_component_1.TitleList
            ],
            imports: [
                platform_browser_1.BrowserModule, http_1.HttpClientModule
            ],
            providers: [titleService_1.TitleService],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;


/***/ }),

/***/ "./ClientApp/app/shared/titleService.ts":
/***/ (function(module, exports, __webpack_require__) {

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
var http_1 = __webpack_require__("./node_modules/@angular/common/esm5/http.js");
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
__webpack_require__("./node_modules/rxjs/_esm5/add/operator/map.js");
var TitleService = /** @class */ (function () {
    function TitleService(http) {
        this.http = http;
        this.titles = [];
    }
    TitleService.prototype.loadTitles = function () {
        var _this = this;
        return this.http.get("/api/title")
            .map(function (data) {
            _this.titles = data;
            return true;
        });
    };
    TitleService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], TitleService);
    return TitleService;
}());
exports.TitleService = TitleService;


/***/ }),

/***/ "./ClientApp/app/title/titleList.component.css":
/***/ (function(module, exports) {

module.exports = "\r\n.title-tile {\r\n    height: 300px;\r\n}\r\n\r\n.title-tile img {\r\n    max-width: 100px;\r\n    float: left;\r\n    margin: 0 4px;\r\n    border: solid 1px black;\r\n}\r\n"

/***/ }),

/***/ "./ClientApp/app/title/titleList.component.html":
/***/ (function(module, exports) {

module.exports = "\r\n<div class=\"row\">\r\n\r\n    <div class=\"title-tile col-md-4 well well-sm\" *ngFor=\"let t of titles\">\r\n        <img [src]=\"t.poster\"  [alt]=\"t.name\" class=\"img-responsive\"/>\r\n        <h3>{{ t.name }} : {{ t.year }}</h3>\r\n        <div>{{t.genre}} : {{t.runtime}}</div>\r\n        <div><strong>Actors</strong>: {{t.actors}}</div>\r\n        <div><strong>Plot</strong>: {{t.plot}}</div>\r\n        <button id=\"addButton\" class=\"btn btn-primary btn-sm pull-right\">Add</button>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/title/titleList.component.ts":
/***/ (function(module, exports, __webpack_require__) {

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
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var titleService_1 = __webpack_require__("./ClientApp/app/shared/titleService.ts");
var TitleList = /** @class */ (function () {
    function TitleList(titleService) {
        this.titleService = titleService;
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
    TitleList = __decorate([
        core_1.Component({
            selector: "title-list",
            template: __webpack_require__("./ClientApp/app/title/titleList.component.html"),
            styles: [__webpack_require__("./ClientApp/app/title/titleList.component.css")]
        }),
        __metadata("design:paramtypes", [titleService_1.TitleService])
    ], TitleList);
    return TitleList;
}());
exports.TitleList = TitleList;


/***/ }),

/***/ "./ClientApp/environments/environment.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
Object.defineProperty(exports, "__esModule", { value: true });
exports.environment = {
    production: false
};


/***/ }),

/***/ "./ClientApp/main.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var platform_browser_dynamic_1 = __webpack_require__("./node_modules/@angular/platform-browser-dynamic/esm5/platform-browser-dynamic.js");
var app_module_1 = __webpack_require__("./ClientApp/app/app.module.ts");
var environment_1 = __webpack_require__("./ClientApp/environments/environment.ts");
if (environment_1.environment.production) {
    core_1.enableProdMode();
}
platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_module_1.AppModule)
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("./ClientApp/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map