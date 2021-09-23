// Create a myPetsArray array here
var myPetsArray = ["Dog", "Cat"];
// End of myPetsArray array

function myArrayFunction(myPets) {
  var myNewPets = [...myPets];
  // Only change code below this line

  myNewPets.push("Bird", "Fish");
  myNewPets.pop();
  myNewPets.shift();
  myNewPets.unshift("Lion");
  var firstPet = myNewPets[0];
  var lastPet = myNewPets[-1];
  return myNewPets;
  // Only change code above this line
}
console.log(myArrayFunction(myPetsArray));
module.exports = myArrayFunction;
