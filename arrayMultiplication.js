const multiplyPolinomArrays = (arr1, arr2) => {
    const resultArr = [];
    arr1.forEach((i, iInd) => {
        arr2.forEach((j, jInd) => {
            const resultInd = iInd + jInd;
            if (typeof resultArr[resultInd] !== "number") resultArr[resultInd] = 0;
            resultArr[resultInd] += i * j;
        });
    });
    return resultArr;
};


// Тесты

const arrayOfTestData = [
    {
        arr1: [-2, 4],
        arr2: [4, 6],
        result: [-8, 4, 24]
    },
    {
        arr1: [-1, 3, 9],
        arr2: [7, 4, -3],
        result: [-7, 17, 78, 27, -27]
    },
    {
        arr1: [2, -6, 9],
        arr2: [5, -8],
        result: [10, -46, 93, -72]
    },
    {
        arr1: [2, -6, 9],
        arr2: [5, -8],
        result: [10, -46, 93, -722]
    },
    {
        arr1: [-2, -6, -10],
        arr2: [1, 7, 35, -13],
        result: [-2, -20, -122, -254, -272, 130]
    },
]

arrayOfTestData.forEach((testItem, index) => {
    let isPassed = true
    const multipliedArrays = multiplyPolinomArrays(testItem.arr1, testItem.arr2)
    const result = testItem.result
    if (multipliedArrays.length !== result.length) isPassed = false
    multipliedArrays.forEach((i, ind) => {
        if (i !== result[ind]) isPassed = false
    })
    if (isPassed) console.log(`Тест ${index} пройден`)
    else console.log(`Тест ${index} провален`)
})


