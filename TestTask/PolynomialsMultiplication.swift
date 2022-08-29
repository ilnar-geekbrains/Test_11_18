//MARK: - Функция перемножения коэффициентов двух полиномов
func multiplication(_ poly1: [Int], _ poly2: [Int]) -> [Int] {
    
    // Выяснем, какой степенью обладает каждый из полиномов
    let exponentOfArr1 = poly1.count
    let exponentOfArr2 = poly2.count
    
    let biggestPoly: [Int]
    let smallestPoly: [Int]
    
    // Выяснем, какой из полиномов обладает наибольшей степенью, а какой - наименьшей
    if exponentOfArr1 > exponentOfArr2 {
        biggestPoly = poly1
        smallestPoly = poly2
    } else {
        biggestPoly = poly2
        smallestPoly = poly1
    }
    
    // Создаем результирующий полином
    var resultPoly = [Int]()
    
    // Подготавливаем результирующий полином ( его максимальный размер равен произведению степеней полиномов )
    for _ in 0...(exponentOfArr1 * exponentOfArr2) {
        resultPoly.append(0)
    }
    
    // Выполняем поэлементное умножение полиномов.
    for smallestPolyIndex in smallestPoly.indices {
        
        for biggestPolyIndex in biggestPoly.indices {
            
            // Берем элементы, с которыми мы будем работать из нужных полиномов
            let smallestPolyElem = smallestPoly[smallestPolyIndex]
            let biggestPolyElem = biggestPoly[biggestPolyIndex]
            let resultPolyElem = resultPoly[smallestPolyIndex + biggestPolyIndex]
            
            // Высчитываем итоговый коэф. и записываем его в результирующий полином
            let totalCoef = smallestPolyElem * biggestPolyElem
            resultPoly[ smallestPolyIndex + biggestPolyIndex ] = resultPolyElem + totalCoef
        }
    }
    
    // Убираем нулевые коэф. из итогового полинома
    resultPoly = resultPoly.filter { $0 != 0}
    
    return resultPoly
}

//MARK: - Тесты
var poly1: [Int]
var poly2: [Int]

poly1 = [0]
poly2 = [0]
if multiplication(poly1, poly2).isEmpty {
    print("Test passed")
} else {
    print("Test failed")
}

poly1 = [1]
poly2 = [0]
if multiplication(poly1, poly2).isEmpty {
    print("Test passed")
} else {
    print("Test failed")
}

poly1 = [1,1,1,1,1,1,1]
poly2 = [1,10,0,0]
if multiplication(poly1, poly2) == [1, 11, 11, 11, 11, 11, 11, 10] {
    print("Test passed")
} else {
    print("Test failed")
}

poly1 = [-1, 1]
poly2 = [1, 1]
if multiplication(poly1, poly2) == [-1, 1] {
    print("Test passed")
} else {
    print("Test failed")
}

poly1 = [-3, 1]
poly2 = [3, 1]
if multiplication(poly1, poly2) == [-9, 1] {
    print("Test passed")
} else {
    print("Test failed")
}
