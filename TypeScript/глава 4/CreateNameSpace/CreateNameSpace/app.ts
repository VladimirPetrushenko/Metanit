/// <reference path="personnel.ts" />

let tom = new Personnel.Employee("Tom")
console.log(tom.name);

let sam = new Personnel.Manager("Sam");
console.log(sam.name);
require('readline').createInterface({
    input: process.stdin
});