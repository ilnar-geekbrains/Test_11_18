function arrayMultiplication(firstArray, secondArray) {
  const resultArray = []
  firstArray.forEach((value1, pos1) => {
    secondArray.forEach((value2, pos2) => {
      let resultValue = value1 * value2;

      const resultPos = pos1 + pos2;

      const prevValue = resultArray[resultPos];
      if (prevValue != undefined) {
        resultValue += prevValue;
      }

      resultArray[resultPos] = resultValue;
    });
  });


  while (resultArray.length > 0 && resultArray[resultArray.length - 1] === 0) {
    resultArray.pop();
  }

  return resultArray;
}

function testingCase(resultArray, expectArray) {
  return JSON.stringify(resultArray) === JSON.stringify(expectArray);
}

console.log('test 1', testingCase(arrayMultiplication([-1], [1, 2, 3]), [-1, -2, -3]), )
console.log('test 2', testingCase(arrayMultiplication([], []), []))
console.log('test 3', testingCase(arrayMultiplication([1, 2], [2, 1]), [2, 5, 2]))
console.log('test 4', testingCase(arrayMultiplication([1, 0, 0], [1, 2, 3]), [1, 2, 3]))