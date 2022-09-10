// Программа для копирования массива
let makeNewArray = function (arr) {
    return arr.concat([])
}
let testNewArray = function (arr) {
    if(makeNewArray(arr) === arr) {
        document.writeln('тест первой программы провален' + "<br>")
    }
    else {
        document.writeln('тест первой программы пройден' + "<br>")
    }
}

// Тестируем
const testArray = [1,2,3]
const testArray2 = [1,2,3,4]
const testArray3 = ['1','2','3','4','5']

testNewArray(testArray)
testNewArray(testArray2)
testNewArray(testArray3)

// Программа для произведения массивов

let cross = function (a1, a2) {
    let result = [];
    a1.forEach(function (a, i) {
        a2.forEach(function (b, j) {
            result[i + j] = (result[i + j] || 0) + a * b;
        });
    });
    return result;
}

let multiplyArrays = function (arr) {
    return arr.reduce(cross)
}

// Тестируем
let testMultiplyArrays = function (input, output) {
    let result = multiplyArrays(input)
    return (result.length === output.length) && result.every(function(element, index) {
        return element === output[index];
    });
}

const inputData = [[-1, 1], [2, 1]]
const outputData = [-2, 1, 1]

const inputData2 = [[-2, 1], [2, 1]]
const outputData2 = [-4, 0, 1]

const inputData3 = [[-1, 4], [2, 5]]
const outputData3 = [-2, 3, 20]


document.writeln(testMultiplyArrays(inputData, outputData))
document.writeln(testMultiplyArrays(inputData2, outputData2))
document.writeln(testMultiplyArrays(inputData3, outputData3))