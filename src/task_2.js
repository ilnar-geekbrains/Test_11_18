/**
 * Возвращает произведение массивов
 * @param {Array} array1 первый массив
 * @param {Array} array2 второй массив
 * @returns 
 */
const multiplicationArray = function (array1, array2) {
	const resultArray = Array(array1.length + array2.length).fill(0);

	array1.forEach((val1, i) => {
		array2.forEach((val2, j) => {
			resultArray[i + j] += val1 * val2;
		});
	});

	return resultArray;
}

module.exports = multiplicationArray;
