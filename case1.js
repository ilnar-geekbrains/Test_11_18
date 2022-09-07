const testCase1 = [1, 2, 3, 4, 5]
const testCase2 = false;
const testCase3 = 1222;
const testCase4 = '[1, 2, 3]';
const testCase5 = [];
const testCase6 = {1: 1, 2: 2, 3: 3};
const testCase7 = null;
const testCase8 = undefined;

testingCase('testCase1', testCase1);
testingCase('testCase2', testCase2);
testingCase('testCase3', testCase3);
testingCase('testCase4', testCase4);
testingCase('testCase5', testCase5);
testingCase('testCase6', testCase6);
testingCase('testCase7', testCase7);
testingCase('testCase8', testCase8);


function copyArray(arr) {
  if(!Array.isArray(arr)) {
    throw new Error('The argument must be an array!')
  }
  return [...arr]
}

function testingCase(description, testCase) {
  try {
    const newArray = copyArray(testCase)
    console.assert(testCase !== newArray, description, 'not copied!', newArray.toString(), testCase.toString())
  } catch (e) {
    console.assert(false, description, e.message, 'this type ' + typeof testCase)
  }
}

