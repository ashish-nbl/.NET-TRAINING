"use strict";

console.log("Hello From Js");


{
    let a=4;
}
// a=23;
// console.log(a);
const arr = [1,2]
arr.push(3)
console.log(arr)

// function factorial(num)
// {
//     let ans=1;
//     for(let i=1;i<=num;i++)
//     {
//         ans*=i;
//     }
//     return ans;
// }

// const result=factorial(5);
// console.log(result);

const result=function factorial(num)
{
    let ans=1;
    for(let i=1;i<=num;i++)
    {
        ans*=i;
    }
    return ans;
}

console.log(result(5)); 
result(5); 



function fibonaci(num)
{
    let i=1;
    let a=0,b=1;
    let c;
    console.log(a + " ");
    console.log(b + " ");

    while(i<=num-2)
    {
        c=a+b;
        a=b;
        b=c;
        console.log(b + " ");
        i++;
    }

}

fibonaci(6);

function primeNumber(num) {
    for (let i = 2; i <= num; i++) {
        let count = 0;

        for (let j = 1; j <= i; j++) {
            if (i % j == 0) {
                count++;
            }
        }

        if (count == 2) {
            console.log(i);
        }
    }
}

primeNumber(10);


// const user={
//     name:"Amit",

//     getName:function()
//     {
//        console.log(this.name);
//     }
// }
// user.getName()

const user2={
    name:"raju",
    address:{
        getName:()=>{
            console.log(this.name);
            console.log(this.name+ "your address is ABC");
        }
    }
}

user2.address.getName();


const user = {
  name: "Rahul",

  greet: function () {
    console.log("greet this:", this);

    const inner = () => {
      console.log("inner this:", this);
      console.log(this.name);
    };

    inner();
  }
};

user.greet();

function outer() {
  console.log(this);

  const inner = () => {
    console.log(this);
  };

  inner();
}

outer();


const users=[
    {
        name:"Ashish",
        age:22
    },
    {
        name:"Ajay",
        age:23
    }
]

const updatedUser=users.map(user=>{
    return {
        ...user,
        gender:"male"
    }
})

console.log(updatedUser);


const numbers=[1,2,3,4,5]

const modified=numbers.map((item)=>{
    return item*2
})

console.log(modified);