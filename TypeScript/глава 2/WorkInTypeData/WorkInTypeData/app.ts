import { stdin } from "node:process";

let someAnyValue: any = "12";
let number: number = <number>someAnyValue;
console.log(number);

let someAnyValueToo: any = "33";
let numberTwo: number = someAnyValueToo as number;
console.log(numberTwo);


let someAnyValueAsWell: any = 3;
let str: string = someAnyValueAsWell as string;
console.log(str);

let someUnionValue: string | number = "3";
let strUnion: string = someUnionValue;
console.log(strUnion);

require('readline').createInterface({
    input: process.stdin
})