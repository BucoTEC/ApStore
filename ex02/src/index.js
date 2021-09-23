// Create a temps array here
var temps = [
  [31, 32, 19, 37],
  [29, 27, 55, 36],
  [17, 27, 42, 46],
  [29, 52, 21, 64],
  [91, 27, 31, 61],
];
// End of temps array

function myArrayFunction(arr) {
  var newTemps = [...arr];
  var averageDayTemp = [];
  // Only change code below this line
  var sum1 = 0;

  for (var i = 0; i < newTemps[0].length; i++) {
    sum1 += newTemps[0][i];
  }
  var avr1 = sum1 / 4;

  var sum2 = 0;

  for (var i = 0; i < newTemps[1].length; i++) {
    sum2 += newTemps[1][i];
  }
  var avr2 = sum2 / 4;

  var sum3 = 0;

  for (var i = 0; i < newTemps[2].length; i++) {
    sum3 += newTemps[2][i];
  }
  var avr3 = sum3 / 4;

  var sum4 = 0;

  for (var i = 0; i < newTemps[3].length; i++) {
    sum4 += newTemps[3][i];
  }
  var avr4 = sum4 / 4;

  var sum5 = 0;

  for (var i = 0; i < newTemps[4].length; i++) {
    sum5 += newTemps[4][i];
  }
  var avr5 = sum5 / 4;

  averageDayTemp.push(avr1, avr2, avr3, avr4, avr5);
  // Only change code above this line
  return averageDayTemp;
}
console.log(myArrayFunction(temps));
module.exports = myArrayFunction;
