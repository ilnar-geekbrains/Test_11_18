import numpy as np


def ManualInput():
    print("Введите количество элементов первого полинова: ")
    while True:
        try:
            elementsCountFirst = int(input())
        except ValueError:
            print('Введите число')
        else:
            break

    firstArray = []

    print("Введите элементы первого полинома: ")
    for i in range(elementsCountFirst):
        while True:
            try:
                t = int(input())
            except ValueError:
                print('Введите число')
            else:
                firstArray.append(t)
                break

    print("Введите количество элементов второго полинова: ")
    while True:
        try:
            elementsCountSecond = int(input())
        except ValueError:
            print('Введите число')
        else:
            break

    secondArray = []

    print("Введите элементы второго полинома: ")
    for i in range(elementsCountFirst):
        while True:
            try:
                t = int(input())
            except ValueError:
                print('Введите число')
            else:
                secondArray.append(t)
                break

    multiplieResult = Multiplier(firstArray, secondArray)
    print(str(firstArray) + " * " + str(secondArray) + " = " + str(multiplieResult))


def UnitTests():
    firstTestA = [1, 2, 3, 5]
    firstTestB = [0]
    firstTestResult = Multiplier(firstTestA, firstTestB)
    if firstTestResult == [0, 0, 0, 0]:
        print('First test is true')
    else:
        print('First test is failed')

    secondTestA = [1, 2, 3, 5]
    secondTestB = [-3, -1, -7]
    secondTestResult = Multiplier(secondTestA, secondTestB)
    if secondTestResult == [-3, -7, -18, -32, -26, -35]:
        print('Second test is true')
    else:
        print('Second test is failed')


    thirdTestA = [12, 23]
    thirdTestB = [2, 0, -7]
    thirdTestResult = Multiplier(thirdTestA, thirdTestB)
    if thirdTestResult == [24, 46, -84, -161]:
        print('Third test is true')
    else:
        print('Third test is failed1')


def Multiplier(A, B):
    result = np.zeros(len(A) + len(B) - 1, dtype=int)
    for i in range(len(A)):
        for j in range(len(B)):
            result[i + j] += A[i] * B[j]

    return result.tolist() 

if __name__ == '__main__':
    print("Выберите функционал программы: ")
    print("   1. Ручной ввод: ")
    print("   2. Юнит-Тесты: ")

    while True:
        try:
            key = int(input())
        except ValueError:
            print('Введите число')
        else:
            if 0 < key < 3:
                break
    
    if key == 1:
        ManualInput()
    elif key == 2: 
        UnitTests()

    