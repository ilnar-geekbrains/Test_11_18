
/**
 * Method to multiply two arrays, where each array represents polynom coefficients.
 *
 * @return array of coefficients of a polynom, which is a product of given two.
**/
function multiplyArrays(array1, array2) {
	const resultArray = [];

	array1.forEach((value1, pos1) => {
		array2.forEach((value2, pos2) => {
			// Result coefficient is the product of two coefficients
			let resultValue = value1 * value2;

			// Result position is the sum of two positions
			const resultPos = pos1 + pos2;

			// Coefficient also has to be added to the previous value at this position (if exists)
			const prevValue = resultArray[resultPos];
			if (prevValue != undefined) {
				resultValue += prevValue;
			}

			// Save
			resultArray[resultPos] = resultValue;
		});
	});

	// Remove zero tail
	while (resultArray.length > 0 && resultArray[resultArray.length - 1] == 0) {
		resultArray.pop();
	}

	return resultArray;
}

module.exports = multiplyArrays;