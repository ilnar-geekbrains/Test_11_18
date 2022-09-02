num_el_1 = int(input("Введите количество элементов в первом массиве: "))
mas1 = [int(input("Введите элемент: ")) for i in range(num_el_1)]
print(mas1)

num_el_2 = int(input("Введите количество элементов во втором массиве: "))
mas2 = [int(input("Введите элемент: ")) for j in range(num_el_2)]
print(mas2)

#test1
while mas1 == []:
    print("Введите элементы массива 1")
    num_el_1 = int(input("Введите количество элементов в первом массиве: "))
    mas1 = [int(input("Введите элемент: ")) for i in range(num_el_1)]

#test2
while mas2 == []:
    print("Введите элементы массива 2")
    num_el_2 = int(input("Введите количество элементов во втором массиве: "))
    mas2 = [int(input("Введите элемент: ")) for j in range(num_el_2)]


def proiz_polinomov(mas1,mas2):
    mas3 = [0] * (len(mas1) + len(mas2) - 1)
    for el1 in range(len(mas1)):
        for el2 in range(len(mas2)):
            mas3[el1+el2] += mas1[el1]*mas2[el2]
    print(mas3)
    return mas3

print("Произведение массивов:",proiz_polinomov(mas1,mas2))

#test3
if proiz_polinomov([0,0,0],[0])==[0,0,0]:
    print("Тест пройден")
else:
    print("Тест провален")

#test4
if proiz_polinomov([-1,-2,-3],[-5,-6,-7])==[5, 16, 34, 32, 21]:
    print("Тест пройден")
else:
    print("Тест провален")