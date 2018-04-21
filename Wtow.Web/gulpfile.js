﻿/// <binding AfterBuild='default' />
var gulp = require("gulp");
var uglify = require("gulp-uglify");
var concat = require("gulp-concat");
//var gutil = require('gulp-util');


gulp.task("minify", () => {
    return gulp.src("wwwroot/js/**/*.js")
        .pipe(uglify())
       // .on('error', function (err) { gutil.log(gutil.colors.red('[Error]'), err.toString()); })
        .pipe(concat("wtow.min.js"))
        .pipe(gulp.dest("wwwroot/dist"));
})

gulp.task("default",["minify"])