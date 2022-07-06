const assert = require("node:assert");
const copyArray = require("./task_1");

const assertsArray = [
	{
		array: [],
		newArray: []
	},
	{
		array: [3 ,4 ,5],
		newArray: [3, 4, 5]
	},
	{
		array: [{number: 2, string: 'hello', array: [1, 2, 3, 4]}, 4, [3, 4, 5, 'test'], 'test'],
		newArray: [{number: 2, string: 'hello', array: [1, 2, 3, 4]}, 4, [3, 4, 5, 'test'], 'test'],
	},
];

const testTask1 = function() {
	assertsArray.forEach((value, index) => {
		const newArray = copyArray(value.array);
		
		try {
			assert.deepEqual(value.newArray, newArray, `Тест 1.${index} не пройден`);
			console.log(`Тест 1.${index} пройден`);
		} catch (error) {
			console.log(error.message, error.actual, error.expected);
		}
	});
}

module.exports = testTask1;