// Task1

// Тестовый массив
arrayForTest = ['test1','test2']
// Создание стрелочной функции с указанием входного массива 
const copyArray = (arrayForTest) => {
    resultArray = Array.from(arrayForTest)
    return resultArray
}

console.log(copyArray(arrayForTest))

const equalArrays = (firstArray,secondArray) => {

    if (firstArray.length != secondArray.length) return false; // Мас­си­вы раз­ной дли­ны не рав­ны
  
    for(var i = 0; i < firstArray.length; i++) // Цикл по всем эле­мен­там
        if (firstArray[i] !== secondArray[i]) return false; // Ес­ли хоть один эле­мент от­ли­ча­ет­ся, мас­си­вы не рав­ны
  
    return true; // Ина­че они рав­ны
}

// Тест №1: Сравнение ссылок и значений массива
// Можно сделать через mocha для Node.js, но я решил сделать по - народному - в лоб
const testCopyArray = (resultArray,testArray) => {
    if (equalArrays(resultArray,testArray) && resultArray != testArray) return true
    // Если указатели не равны, то новый массив не являются ссылкой на предыдущий
    else return false
}


console.log(testCopyArray(copyArray(arrayForTest),arrayForTest))




// Task 2

const arrayMultiplication = (firstPosArray, secondPosArray) => {
    // Создание результирующего списка и заполнение нулями
    var resArray = new Array(firstPosArray.length + secondPosArray.length - 1) 
    resArray.fill(0)
    // Проходимся циклом по каждому из списков и ищем конечный результат
    for (var i = 0; i < firstPosArray.length; i++)
        for (var j = 0; j < secondPosArray.length; j++)
            resArray[i + j] += firstPosArray[i] * secondPosArray[j]
    return resArray
}


// Тест №1: True -> тест пройден. 
console.log(equalArrays(arrayMultiplication([-1, 1], [2, 1]),[-2,1,1]) ? "Тест пройден успешно" : "Тест не пройден" ) 

// Тест №2. Матрицы разных размерностей: 4 на 2
console.log(equalArrays(arrayMultiplication([-9, 7, 1, 5], [1, 1]),[-9, -2, 8, 6, 5]) ? "Тест пройден успешно" : "Тест не пройден" ) 

// Тест №3. Матрицы разных размерностей: 4 на 3
console.log(equalArrays(arrayMultiplication([14, 0, 5, -1], [7, 2, 8]),[98, 28, 147, 3, 38, -8]) ? "Тест пройден успешно" : "Тест не пройден" ) 
