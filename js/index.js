const { getSingleton } = require("./src/patterns/Singleton");

const s1 = getSingleton();
const s2 = getSingleton();

const s3 = getSingleton();

console.log(s1 === s2);
console.log(s2 === s3);