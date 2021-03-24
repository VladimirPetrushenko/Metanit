let add = function (a, b) {
    return a + b;
};
let x = add(555, 9875);
console.log(x);
let bubleSort = function (mass, order = false) {
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
};
let mass = [1, 2, 3, 4, 0, 9, 8, 7, 6, 5];
mass = bubleSort(mass);
for (var i = 0; i < mass.length; i++) {
    console.log(mass[i]);
}
x = add(777, 1234);
console.log(x);
let mass1 = [1, 2, 3, 4, 0, 9, 8, 7, 6, 5];
mass1 = bubleSort(mass1, true);
for (var i = 0; i < mass1.length; i++) {
    console.log(mass1[i]);
}
add = function (a, b) {
    return a * b;
};
x = add(777, 1234);
console.log(x);
function concat1(a, b) {
    return a + b;
}
//�������� �������� �������
let concat;
//���������� �������� ���������� ����������
concat = concat1;
console.log(concat(5, 4));
console.log(concat("5", "4"));
function newOperation(x, y, oper) {
    let result = oper(x, y);
    return result;
}
let operationFunc = function (a, b) {
    return a + b;
};
function Multi(a, b) {
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
//# sourceMappingURL=app.js.map