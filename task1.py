#Функция, которая копирует массив
def cop_mass(spisok):
    cop_massiv = list()
    for el in spisok:
        cop_massiv.append(el)
    return cop_massiv

#Пример массива
spisok = [0, 1, 2, 3, 4, 5, 6]
#Вызов функции копирования и сохранения в новый массив
spicok_cop = cop_mass(spisok)
#Вывод полученного списка
print(spicok_cop)