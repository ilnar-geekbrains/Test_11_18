/**
 * Возвращает копию массива соданую при помощи 
 * глубокого рекурсивного копирования массива
 * @param {*} array массив
 * @returns 
 */
const copyArray = function (array) {
	if (Array.isArray(array)) {
		const newArray = array.slice(0);
		for (let i = 0; i < newArray.length; i++) {
			newArray[i] = copyArray(newArray[i]);
		}
		return newArray;
	} else if (typeof array === 'object') {
		const newObj = {};
		for (let key in array) {
			newObj[key] = copyArray(array[key]);
		}
		return newObj;
	} else {
		return array;
	}
}

module.exports = copyArray;