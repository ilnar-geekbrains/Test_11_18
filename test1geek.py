## task1

## тестовый массив
arrayForTest = ['test1', 'test2']

def copyArray (arrayForTest):
    newArray = arrayForTest
    return newArray

print (copyArray(arrayForTest))



# проверка на равенство массивов
def equalArrays (firstArray,secondArray):
    
    # если массивы разной длины
    if len(firstArray) != len (secondArray):
        return False        
    
    # проверка, чтобы все элементы совпадали
    for i in range(len(firstArray)):
        if firstArray[i] != secondArray [i]:
            return False

    # иначе они равны
    return True

## Тест №1: Сравнение ссылок и значений массива

def testCopyArray (resultArray,testArray):

    if equalArrays(resultArray, testArray): #and resultArray != testArray:
        return True
    else:
        return False

print (testCopyArray(copyArray(arrayForTest), arrayForTest))



## tast 2

def arrayMultiplication (firstPosArray, secondPosArray):
    ## Создание результирующего списка и заполнение нулями
    resArray = [0]* (len(firstPosArray) + len(secondPosArray) - 1)

    ## Проходимся циклом по каждому из списков и ищем конечный результат
    for i in range (len(firstPosArray)):
        for j in range (len(secondPosArray)):
            resArray [i+j] += firstPosArray[i] * secondPosArray [j]
        
    return resArray

# Тест №1: True -> тест пройден. 
print("Тест пройден успешно" if equalArrays(arrayMultiplication([-1, 1], [2, 1]),[-2,1,1]) else "Тест не пройден" ) 

# print ("OK" if True else "NO!")

# Тест №2. Матрицы разных размерностей: 4 на 2
print("Тест пройден успешно" if equalArrays(arrayMultiplication([-9, 7, 1, 5], [1, 1]),[-9, -2, 8, 6, 5]) else "Тест не пройден" ) 

# Тест №3. Матрицы разных размерностей: 4 на 3
print("Тест пройден успешно" if equalArrays(arrayMultiplication([14, 0, 5, -1], [7, 2, 8]),[98, 28, 147, 3, 38, -8]) else "Тест не пройден" )