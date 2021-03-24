class User {
    constructor(Id, name, LastName) {
        this.Id = Id;
        this.name = name;
        this.LastName = LastName;
    }
    Log() {
        console.log("Id: " + this.Id + " Name:" + this.name + " LastName:" + this.LastName);
    }
}
let Tom = new User(2, "Tom", "Smith");
Tom.Log();
function personBuilder() {
    let person = function (name, surname) {
        person.fullName = name + " " + surname;
    };
    person.authenticate = function () {
        console.log(person.fullName + " входит в систему с паролем " + person.password);
    };
    return person;
}
let tom = personBuilder();
tom("Tom", "Simpson");
tom.password = "qwerty";
tom.authenticate();
class Employee extends User {
    constructor(employeeCompany, userName) {
        super(1, userName, "sds");
        this.company = employeeCompany;
    }
}
function getUserName(user) {
    return user.name;
}
let alice = new Employee("Microsoft", "Alice");
if (alice instanceof User) {
    console.log("Alice is a User");
}
else {
    console.log("Alice is not a User");
}
console.log(getUserName(alice));
require('readline').createInterface({
    input: process.stdin
});
//# sourceMappingURL=app.js.map