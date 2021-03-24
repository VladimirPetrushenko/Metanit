var Personnel;
(function (Personnel) {
    class Employee {
        constructor(name) {
            this.name = name;
        }
    }
    Personnel.Employee = Employee;
    class Manager {
        constructor(name) {
            this.name = name;
        }
    }
    Personnel.Manager = Manager;
})(Personnel || (Personnel = {}));
/// <reference path="personnel.ts" />
let tom = new Personnel.Employee("Tom");
console.log(tom.name);
let sam = new Personnel.Manager("Sam");
console.log(sam.name);
require('readline').createInterface({
    input: process.stdin
});
//# sourceMappingURL=app.js.map