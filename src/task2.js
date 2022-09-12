function multiplyArrays (arr1, arr2) {
	const resultArr = [];

	arr1.forEach((val1, pos1) => {
		arr2.forEach((val2, pos2) => {
			let resultVal = val1 * val2;

			const resultPos = pos1 + pos2;

			const prevVal = resultArr[resultPos];
			if (prevVal != undefined) {
				resultVal += prevVal;
			}

			resultArr[resultPos] = resultVal;
		});
	});

	return resultArr;
}

module.exports = multiplyArrays;