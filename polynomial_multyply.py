def polynomial_multyply(first_arr, second_arr):
    result = list()
    dict_1 = dict()
    for i in range(len(first_arr)):
        for j in range(len(second_arr)):
            # i + j - степень
            if i + j in dict_1.keys():
                dict_1[i + j] += first_arr[i] * second_arr[j]
            else:
                dict_1[i + j] = first_arr[i] * second_arr[j]

    for i in dict_1.values():
        result.append(i)

    check = {0}
    if set(result) == check:  # случай с нулевым полиномом
        print(0)
    else:
        print(result)


def main():
    polynomial_multyply([-1, 1], [2, 1])
    polynomial_multyply([1, 2, 3], [6, 5, 2])
    polynomial_multyply([4, 4, 4, 4, 4, 4, 4], [5, 5, 5, 5, 5, 5, 5])
    polynomial_multyply([0], [6, 5, 2])
    polynomial_multyply([1], [6, 5, 2])
    polynomial_multyply([0, 1], [6, 5, 2])
    # выводы правильные, проверял в онлайн калькуляторе
    return 0


main()
