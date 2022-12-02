# функция копирования массива
def CopMas(mas):
    copy_list = list()
    for i in range(len(mas)):
        copy_list.append(mas[i])
    # возвращение массива
    return copy_list


def CompositionMas(mas_1, mas_2):
    #создание списка
    mas_composition = [0] * (len(mas_1) + len(mas_2) - 1)
    #умножение всех элементов первого полинома на каждый элемент второго полинома

    for i in range(len(mas_1)):
        for j in range(len(mas_2)):
            mas_composition[i + j] += mas_1[i] * mas_2[j]
    #возвращение массив
    return mas_composition


def Sravnenie(a, b):
    if a == b:
        print(f'При a = {a} верно.')
    else:
        print(f'При a = {a} и b = {b}  не верно')


a = CompositionMas([-1, 1], [2, 1])
b = CopMas([1, 'a'])
print(a, b)
print("Проверка первой задачи")
#Тест первой задачи

#Массив с тестами
mas_test_1 = [[], [1, 2, 3, 4, 5], [1, 'q', 'w', 'e', 'r'], [[1, 2, 'a'], {1: 'a'}, 3, 'e']]
#Массив с результатами
mas_result_1 = [CopMas(i) for i in mas_test_1]
#Сравнение изначального массива с скопированным
for i in range(len(mas_test_1)):
    Sravnenie(mas_test_1[i], mas_result_1[i])

print("Проверка второй задачи")
#Тест второй задачи
#Массив с тестами
mas_test_2 = [[-1, 1], [2, 1], [1, 2, 3], [4, 5, 6, 7], [0], [1, 7, 9], [1, 4, 0], [1],
              [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]]
#Массив ответов
mas_otvet = [[-2, 1, 1], [4, 13, 28, 34, 32, 21], [0, 0, 0], [1, 4, 0],
             [10, 29, 56, 90, 130, 175, 224, 276, 330, 385, 330, 276, 224, 175, 130, 90, 56, 29, 10]]
#Массив рельтатов
mas_result_2 = [0] * (len(mas_test_2) // 2)
for i in range(0, len(mas_test_2) - 1, 2):
    mas_result_2[i // 2] = CompositionMas(mas_test_2[i], mas_test_2[i + 1])
#Сравнение результатов и ответов
for i in range(0, len(mas_otvet), 2):
    Sravnenie(mas_otvet[i], mas_result_2[i])