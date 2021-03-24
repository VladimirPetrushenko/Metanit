let add = function(a: number, b: number): number{
    return a + b;
}

let x = add(555, 9875);
console.log(x);

let bubleSort = function (mass: Array<number>, order: boolean = false): Array<number>{
    let massSort = mass.slice();
    for (var i = 0; i < mass.length; i++) {
        for (var j = i; j < mass.length; j++) {
            if ((massSort[i] > massSort[j]) == order) {
                let temp = massSort[i];
                massSort[i] = massSort[j];
                massSort[j] = temp;
            }
        }
    }
    return massSort;
}

let mass = [1, 2, 3, 4, 0, 9, 8, 7, 6, 5];
mass = bubleSort(mass);
for (var i = 0; i < mass.length; i++) {
    console.log(mass[i]);
}

x = add(777,1234);
console.log(x);

let mass1 = [1, 2, 3, 4, 0, 9, 8, 7, 6, 5];
mass1 = bubleSort(mass1, true);
for (var i = 0; i < mass1.length; i++) {
    console.log(mass1[i]);
}

add = function (a: number, b: number): number {
    return a * b;
}

x = add(777, 1234);
console.log(x);

function concat1(a: number, b: number): number;
function concat1(a: string, b: string): string;
function concat1(a: any, b: any): any {
    return a + b;
}

//создание делегата функции
let concat: (a: any, b: any) => any;
//присвоение делегату конкретную реализацию
concat = concat1;
console.log(concat(5, 4));
console.log(concat("5", "4"));

//Использование делегатов в параметрах функции
function newOperation(x: number, y: number, oper: (a: number, b: number) => number): number {
    let result = oper(x, y);
    return result;
}

let operationFunc = function (a: number, b: number): number {
    return a + b;
}
function Multi(a: number, b: number): number {
    return a * b;
}

console.log(newOperation(10, 30, operationFunc));

operationFunc = Multi;
console.log(newOperation(10, 30, operationFunc));

x = add(777, 1234);
console.log(x);


require('readline').createInterface({
    input: process.stdin
});