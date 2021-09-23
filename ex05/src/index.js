// Only change code below this line
var myNestedArray = [
  ["Dog", 3],
  ["Cat", 2],
];
function myNestedFunction(arr) {
  arr[0][0] = "Toblerone";
  arr[0][1] = 5;
  arr[1][0] = "Milka";
  arr[1][1] = 3;

  return arr;
}
// Only change code above this line
console.log(myNestedFunction(myNestedArray));
module.exports = myNestedFunction;
