// Create a monitorsListArray array here
var monitorsListArray = ["Apple", "Peach", "Berry"];
// End monitorsListArray array

function myMonitorsFunction(arr) {
  var newMonitorsList = [...arr];
  var monitorsList = [];
  // Only change code below this line
  //   var num = 0;
  for (var i = 0; i < 3; i++) {
    monitorsList.push((newMonitorsList[i] = [newMonitorsList[i], i + 1]));
  }
  return monitorsList;
  // Only change code above this line
}

console.log(myMonitorsFunction(monitorsListArray));
module.exports = myMonitorsFunction;
