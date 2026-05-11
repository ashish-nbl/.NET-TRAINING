console.log("Hello from js");
console.log(x);
var x=12;

// arrowFunCall();

var arrowFunCall=()=>{
    console.log("Hello from arrow function");
}


function normalFunctionCall()
{
    console.log("hello from normal function");
}
normalFunctionCall();


var a=10;
function1();
function2();


function function1()
{
    // var a=20;
    console.log(a);
}

function function2()
{
    var a=30;
    console.log(a);
}

// console.log(var1);
// console.log(var3);
//this both are refrence error


let var1=15;
var var2=41;
const var3=34;

// let var1=23; //this is syntax error

// var3=34; //this is type error

if (true) {
  var as = 10;
  let bs = 20;
}

console.log(as);
var as=34;
// console.log(bs);


//shadowing
var shaddow=10;
{
  var shaddow=20;

    console.log(shaddow);
}
console.log(shaddow);

var v1=44;
{
    let v1=44;
    console.log(v1);
}

console.log(v1);


//illegal shadowing
// let v1=44;
// {
//     var v1=44;
//     console.log(v1);
// }

// console.log(v1);


//closure

function z()
{
    var outer=100;
    function y()
    {
        var inner=10;
        function x()
        {
            console.log(inner,outer);
        }
        return x();
    }
    return y();
}
 z();


//  for (let i = 1; i <= 3; i++) {
//               debugger;

//     setTimeout(function() {
//         console.log(i);
//     }, i*1000);
// }


 for (var i = 1; i <= 3; i++) {
              debugger;

    setTimeout(function() {
        console.log(i);
    }, i*1000);
}

function demo(callback)
{
    console.log("Hello");
    callback()
}

demo(function callback()
{
    console.log("Hii");
})