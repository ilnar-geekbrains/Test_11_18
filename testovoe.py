import copy

#создание массива чисел
a = [[10, 15, 4],
    [13, 44, 66],
    [6,7,103]]

#глубокое копирование, а не только ссылки на массив
b = copy.deepcopy(a)

if (a==b):
    print('Тест пройден!')
else:
    print('Тест провален(')

#проверка после добавления
a.append(5)

if (a==b):
    print('Тест пройден!')
else:
    print('Тест провален(')

#второе задание

#импорт библиотеки для работы с массивами
import numpy as np
a1 = np.array([-1, 1])
b1 = np.array([2, 1])

print(np.convolve(a1,b1))#свернуть массив

a2 = np.array([-2, 4]) #(-2 + 4x)
b2 = np.array([5, 1])  #(5 + x)
c2 = np.convolve(a2,b2) # через присваивание
print(c2)# (-10 + 18x + 4x^2)
