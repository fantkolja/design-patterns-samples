// ###### Method 1

// class Singleton {
//   static #_instance = null;

//   constructor() {
//     if (Singleton.#_instance) {
//       return Singleton.#_instance;
//     } else {
//       console.log('Initializing Singleton');
//     }
//   }

//   static getInstance() {
//     if (!this.#_instance) {
//       this.#_instance = new Singleton();
//     }
//     return this.#_instance;
//   }
// }


// ###### Method 2

// let _instance = null;

// class Singleton {
//   constructor() {
//     if (!_instance) {
//       instance = this;
//     }
//     return instance;
//   }
// }

// const insatnce = new Singleton();
// const insatnce = new Singleton();


// ###### Method 3

// const singltonize = (ctor) => {
//   let instance = null;

//   return () => {
//     if (!instance) {
//       instance = new ctor();
//     }
//     return instance;
//   };
// };

// const getSingleton = singltonize(
//   class Singleton {
//     constructor() {
//       console.log('Initializing Singleton');
//     }
//   }
// );

// module.exports = { getSingleton };