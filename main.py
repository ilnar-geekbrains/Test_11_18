# функция копирования массива при помощи списочного выражения
def copy_mas(mas):
    mas_copy = [i for i in mas]
    # Возвращаем скопированный массив
    return mas_copy


def composition_mas(mas_1, mas_2):
    # Создание списка на нужное нам колличество элементов
    mas_composition = [0] * (len(mas_1) + len(mas_2) - 1)
    # Умножаем все элементы первого полинома на каждый элемент второго полинома и сохраняем в mas_compositionmas_composition

    for i in range(len(mas_1)):
        for j in range(len(mas_2)):
            mas_composition[i + j] += mas_1[i] * mas_2[j]
    # Возвращаем массив
    return mas_composition


def sravnenie(a, b):
    if a == b:
        print(f"При a = {a} все верно.")
    else:
        print(f"При a = {a} и b = {b} программа работает не верно")


a = composition_mas([-1, 1], [2, 1])ssМ

print("Проверка второй задачи:")
# Тест второй задачи
# Массив с тестами
mas_test_2 = [[-1, 1], [2, 1], [1, 2, 3], [4, 5, 6, 7], [0], [1, 7, 9], [1, 4, 0], [1],
              [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]]
# Массив ответов
mas_otvet = [[-2, 1, 1], [4, 13, 28, 34, 32, 21], [0, 0, 0], [1, 4, 0],
             [10, 29, 56, 90, 130, 175, 224, 276, 330, 385, 330, 276, 224, 175, 130, 90, 56, 29, 10]]
# Массив рельтатов
mas_result_2 = [0] * (len(mas_test_2) // 2)
for i in range(0, len(mas_test_2) - 1, 2):
    mas_result_2[i // 2] = composition_mas(mas_test_2[i], mas_test_2[i + 1])
# Сравнение результатов и ответов
for i in range(0, len(mas_otvet), ):
    sravnenie(mas_otvet[i], mas_result_2[i])
