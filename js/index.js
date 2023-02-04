const { Person } = require('./src/patterns/Prototype/index');

const vasya = new Person('Vasya', 23);


const mykola = {
  name: 'Mykola',
  age: 23,
};

const petya = {
  name: 'Petro',
  age: 28,
  siblings: ['Mykola', 'Vasya'],
  father: mykola,
};

mykola.son = petya;

function shallowClone(obj) {
  const clonedObj = {};
  for (let key in obj) {
    clonedObj[key] = obj[key];
  }
  return clonedObj;
}

const createDeepCloner = (obj) => {
  const memoizedRefs = [obj];

  const deepClone = (innerObj = obj) => {
    const clonedObj = {};
    for (let key in innerObj) {
      const nextValue = innerObj[key];
      
      if (typeof nextValue === 'object' && nextValue !== null) {
        const oldValue = memoizedRefs.find(ref => ref === nextValue);
        if (oldValue) {
          clonedObj[key] = oldValue;
        } else {
          const result = deepClone(nextValue);
          clonedObj[key] = result;
          memoizedRefs.push(result);
        }
        
      } else {
        clonedObj[key] = obj[key];
      }
    }
    return clonedObj;
  };

  return deepClone;
};

// function simpleDeepClone(obj) {
// }

const petyaCloner = createDeepCloner(petya);
const clonoPetya = petyaCloner();
clonoPetya.father.name = 'Ivan';

console.log(petya);
console.log(clonoPetya);