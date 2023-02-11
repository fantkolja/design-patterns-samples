/**
 * Function `double` takes number array and returns
 * a new array after doubling each item
 */

Array.prototype.customMap = function customMapHandler(cb) {
  const results = [];
  for (let i = 0, n = this.length; i < n; i++) {
    results.push(cb(this[i], i, this));
  }
  return results;
};

Array.prototype.customMap = function customMapHandler(cb) {
  const results = [];
  for (let i = 0, n = this.length; i < n; i++) {
    results.push(cb(this[i], i, this));
  }
  return results;
};


const double = (arr) => arr.customMap(item => item * 2);

console.log(double([1, 2, 3]));
console.log(double([22, 44, 11]));

/**
 * Function `sum` takes number array and returns
 * the sum of each array item
 */

const sum = (arr) => arr.reduce((total, next) => (total += next), 0);

console.log(sum([1, 2, 3]));
console.log(sum([22, 44, 11]));

/**
 * Add a click handler to an HTML element, which toggles on click 
 * "highlight" class and the text from "Add highlight" to "Remove highlight"
 */

function addHighlightListener(el) {
  el.addEventListener('click', () => {
    el.classList.toggle('highlight');
    el.innerText === 'Add highlight' ? 
      el.innerText = 'Remove highlight' :
      el.innerText = 'Add highlight';
  });
}

