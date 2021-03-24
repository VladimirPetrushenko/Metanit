class User {
    constructor(_name, _age) {
        this.name = _name;
        this.age = _age;
    }
}
var tom = new User("Том", 29);
console.log("Имя: ", tom.name, " возраст: ", tom.age);
const readline = require('readline');
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
//# sourceMappingURL=app.js.map