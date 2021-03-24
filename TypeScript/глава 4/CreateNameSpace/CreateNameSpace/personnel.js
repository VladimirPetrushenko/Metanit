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
//# sourceMappingURL=personnel.js.map