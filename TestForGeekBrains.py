def entering_array_elements():
    quantity_elements = int(input("Введите количество элементов в массиве: "))
    array = [int(input("Введите элемент: ")) for i in range(quantity_elements)]
    return array

def multiplication_of_polynomials(array1, array2):
    result = [0] * (len(array1) + len(array2) - 1)
    for element1 in range(len(array1)):
        for element2 in range(len(array2)):
            result[element1 + element2] += array1[element1] * array2[element2]
    return result

array1 = entering_array_elements()
array2 = entering_array_elements()
print(multiplication_of_polynomials(array1,array2))

#tests
assert multiplication_of_polynomials([-1, 1],[2,1])==[-2, 1, 1], "Тест провален"
assert multiplication_of_polynomials([0,0,0],[0])==[0,0,0], "Тест провален"
assert multiplication_of_polynomials([-1,-2,-3],[-5,-6,-7])==[5, 16, 34, 32, 21], "Тест провален"
assert multiplication_of_polynomials([],[])==[], "Тест провален"
