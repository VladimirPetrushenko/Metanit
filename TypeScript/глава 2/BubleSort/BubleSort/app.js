let mass;
mass = [2, 3, 4, 12, 11, 2, 3, 5, 7];
for (var i = 0; i < mass.length; i++) {
    for (var j = i + 1; j < mass.length; j++) {
        if (mass[i] < mass[j]) {
            let temp = mass[i];
            mass[i] = mass[j];
            mass[j] = temp;
        }
    }
}
for (var i = 0; i < mass.length; i++) {
    console.log(mass[i] + " ");
}
const readline = require('readline');
var m = require('readline').createInterface({
    input: process.stdin
});
var k = process.stdin;
console.log(k);
require('readline').createInterface({
    input: process.stdin
});
//# sourceMappingURL=app.js.map