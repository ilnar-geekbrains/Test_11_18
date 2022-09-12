const arrayOfTestData = [
    {
        arr1: [7, 1, 0],
        arr2: [4, 4, 4],
        result: [28, 32, 32, 4, 0]
    },
    {
        arr1: [5, 2],
        arr2: [3, -8],
        result: [-7, 17, 78, 27, -27]
    },
    {
        arr1: [4, 2, -2],
        arr2: [7, 1, 9],
        result: [10, -46, 93, -72]
    },
    {
        arr1: [0, 3],
        arr2: [2, 6],
        result: [0, 6, 18]
    },
    {
        arr1: [4, 36, -1],
        arr2: [7, -35, -1],
        result: [28, 112, -1271, -1, 1]
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