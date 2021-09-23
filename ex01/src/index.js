// Create an array here
var myArr = [2, 4, 0, 8, 10];
// End of creating an array

function myArrayFunction(arr) {
  var myItems = [...arr];

  // Only change code below this line
  myItems[2] = 6;
  return myItems;
  // Only change code above this line
}

console.log(myArrayFunction(myArr));
module.exports = myArrayFunction;
