
// Копирование массива
const copyArray = require("./src/task_1");

const array = [1, 4, 5, 6, 3, 4, 5];

const newArray = copyArray(array);

console.log("Копирование массива");
console.log("Array", array, "copyArray", newArray);

// Перемножение массивов
const multiplicationArray = require("./src/task_2");

const resultArray = multiplicationArray(array, newArray);

console.log("Перемножение массивов");
console.log("Array1", array, "Array2", newArray, "multiplicationArray", resultArray);
