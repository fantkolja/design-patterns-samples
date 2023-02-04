class IDCard {
  #_id;
  constructor() {
    this.#_id = Math.random().toString(36).substring(2);
  }

  toString() {
    return this.#_id;
  }
}

class Person {
  #_idCard;
  constructor(name, age) {
    this.name = name;
    this.age = age;
    this.#_idCard = new IDCard();
  }

  introduce() {
    console.log(`Hello, my name is ${this.name}`);
  }

  checkId() {
    console.log(`My ID is "${this.#_idCard}"`);
  }
}

module.exports = { Person, IDCard };