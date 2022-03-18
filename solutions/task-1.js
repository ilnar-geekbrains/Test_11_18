// поверхностное копирование массива

function shallowArrayCopy(arr) {
	const arrayCopy = [...arr];
	return arrayCopy;
}

function shallowArrayCopy2(arr) {
	const arrayCopy = arr.slice();
	return arrayCopy;
}

// глубокое копирование массива массивов

function deepArrayCopy(arr) {
	let arrayCopy = [];

	for (let i = 0; i < arr.length; i++) {
		if (typeof arr[i] === 'object' && arr[i] instanceof Array) {
			arrayCopy.push(deepArrayCopy(arr[i]));
		} else {
			arrayCopy.push(arr[i]);
		}
	}

	return arrayCopy;
}

function deepArrayCopy2(arr) {
	const copy = JSON.parse(JSON.stringify(arr));
	return copy;
}

const deepArray = [1, '2', [3, '4'], [5, [[6]]]];
console.log(deepArrayCopy2(deepArray));
