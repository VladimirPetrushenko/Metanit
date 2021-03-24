class User {
    name: string;
    age: number;
    constructor(_name: string, _age: number) {

        this.name = _name;
        this.age = _age;
    }
}
var tom: User = new User("Том", 29);
console.log("Имя: ", tom.name, " возраст: ", tom.age);

// для задержки командной строки (приблизительный аналог Console.ReadKey())
const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});