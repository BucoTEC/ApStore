// Only change code below this line
function splitArrayInGroups(arr, n) {
  var result = [];
  var num = 0;
  while (num < arr.length && result.length < n) {
    result.push(arr.slice(num, num + n));
    num += n;
  }

  return result;
}
// Only change code above this line

console.log(splitArrayInGroups(["a", "b", "c", "d"], 2));
console.log(splitArrayInGroups([0, 1, 2, 3, 4, 5, 6], 3));
console.log(splitArrayInGroups([0, 1, 2, 3, 4, 5], 2));
console.log(splitArrayInGroups([0, 1, 2, 3, 4, 5, 6, 7, 8], 3));
console.log(splitArrayInGroups([0, 1, 2, 3, 4, 5, 6, 7, 8], 2));
