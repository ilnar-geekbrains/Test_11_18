
const testDataSet = [
	{
		"array1": [],
		"array2": [],
		"resultArray": []
	},
	{
		"array1": [1, 1],
		"array2": [],
		"resultArray": []
	},
	{
		"array1": [],
		"array2": [1, 1],
		"resultArray": []
	},
	{
		"array1": [1, 2],
		"array2": [2, 1],
		"resultArray": [2, 5, 2]
	},
	{
		"array1": [-1],
		"array2": [1, 2, 3],
		"resultArray": [-1, -2, -3]
	},
	{
		"array1": [1, 0, 0],
		"array2": [1, 2, 3],
		"resultArray": [1, 2, 3]
	},
	{
		"array1": [0, 1],
		"array2": [1, 2, 3],
		"resultArray": [0, 1, 2, 3]
	}
];

function multiplyArraysTest() {	
	const multiplyArrays = require('../src/task2.js');

	testDataSet.forEach((data) => {
		const array1 = JSON.stringify(data["array1"]);
		const array2 = JSON.stringify(data["array2"]);
		const resultArray = JSON.stringify(data["resultArray"]);
		const computedArray = JSON.stringify(multiplyArrays(data["array1"], data["array2"]));

		console.log("\nChecking on " + array1 + ", " + array2 + "...");
		if (resultArray == computedArray) {
			console.log(resultArray + " - SUCCESS");
		} else {
			console.error(computedArray + ", but " + resultArray + " expected - FAIL")
			throw "Test failed!"
		}
	});
}

multiplyArraysTest();
