const arr = [1, 2, 3];




























// class Range {
//   constructor(from, to) {
//     this.from = from;
//     this.to = to;
//   }

//   [Symbol.iterator]() {
//     let current = null;

//     return {
//       next: () => {
//         if (current === null) {
//           current = this.from;
//         } else {
//           current++;
//         }
//         return current <= this.to ? {
//           value: current,
//           done: false,
//         } : {
//           value: undefined,
//           done: true,
//         };
//       }};
//   }
// };


// const range = new Range(1, 3);


// console.log([...range]);
// console.log(...range);