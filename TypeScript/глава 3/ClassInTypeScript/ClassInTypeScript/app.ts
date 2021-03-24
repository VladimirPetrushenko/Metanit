class User {
    Id: number;
    name: string;
    LastName: string;
    constructor(Id: number, name: string, LastName: string) {
        this.Id = Id;
        this.name = name;
        this.LastName = LastName;
    }
    Log() {
        console.log("Id: " + this.Id + " Name:" + this.name + " LastName:" + this.LastName);
    }
}
let Tom: User = new User(2, "Tom", "Smith");
Tom.Log();

interface PersonInfo {
    (name: string, surname: string): void;
    fullName: string;
    password: string;
    authenticate(): void;
}

function personBuilder(): PersonInfo {
    let person: PersonInfo = <PersonInfo>function(name: string, surname: string): void {
            person.fullName = name + " " + surname;
        }
    person.authenticate = function () {
        console.log(person.fullName + " входит в систему с паролем " + person.password);
    };
    return person;
}

let tom = personBuilder();
tom("Tom", "Simpson");
tom.password = "qwerty";
tom.authenticate();

interface IUser {
    name: string;
}
class Employee extends User {
    company: string;
    constructor(employeeCompany: string, userName: string) {
        super(1,userName,"sds");
        this.company = employeeCompany;
    }
}
function getUserName(user: IUser): string {
    return user.name;
}

let alice: Employee = new Employee("Microsoft", "Alice");
if (alice instanceof User) {
    console.log("Alice is a User");
}
else {
    console.log("Alice is not a User");
}
console.log(getUserName(alice as IUser));

require('readline').createInterface({
    input: process.stdin
});