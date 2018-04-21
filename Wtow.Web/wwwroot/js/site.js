// Gulp will change this to anonymous function
(function MyIIFE() {

    // Gulp will get rid of this local variable as there are no refereance on it.
    var localVar = 10;

    // Gulp will remove the varable as it's only used once
    var myString = "2321";

    //Gulp will rename this varable to short name
    var myInt = 7;

    //Gulp will rename this varable to short name
    var myArray = [myInt, myString, 4];

    
    function myFunction() {
        if (!(new Date()).getSeconds() % myInt)
            myArray.forEach(function (el) { alert(el) });
    }

    myFunction();

})();

// Gulp will keep this varable as and it's name as it is global
var globalVar = 10;