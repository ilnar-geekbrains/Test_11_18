const assert = require("node:assert");
const multiplicationArray = require("./task_2");

const assertsArray = [
	{
		array1: [1, 4, 5, 6, 3, 4, 5],
		array2: [1, 4, 5, 6, 3, 4, 5],
		resultArray: [1, 8, 26, 52, 79, 92, 108, 116, 107, 84, 46, 40, 25, 0]
	},
	{
		array1: [3, 4, 5],
		array2: [3, 4, 5],
		resultArray: [9, 24, 46, 40, 25, 0]
	},
	{
		array1: [],
		array2: [],
		resultArray: []
	},
];

const testTask2 = function () {
	assertsArray.forEach((value, index) => {
		const resultArray = multiplicationArray(value.array1, value.array2);

		try {
			assert.deepEqual(value.resultArray, resultArray, `Тест 2.${index} не пройден`);
			console.log(`Тест 2.${index} пройден`);
		} catch (error) {
			console.log(error.message, error.actual, error.expected);
		}
	});
}

module.exports = testTask2;
