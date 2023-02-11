/**
 * Function `double` takes number array and returns
 * a new array after doubling each item
 */

function double(arr) {
  const results = [];
  for (let i = 0, n = arr.length; i < n; i++) {
    results.push(arr[i] * 2);
  }
  return results;
}

console.log(double([1, 2, 3]));
console.log(double([22, 44, 11]));

/**
 * Function `sum` takes number array and returns
 * the sum of each array item
 */

function sum(arr) {
  let result = 0;
  for (let i = 0, n = arr.length; i < n; i++) {
    result += arr[i];
  }
  return result;
}

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