def arrays_mul(arr_1, arr_2):
    res = {}
    for i in range(len(arr_1)):
        for j in range(len(arr_2)):
            if i + j in res.keys():
                res[i + j] += arr_1[i] * arr_2[j]
            else:
                res[i + j] = arr_1[i] * arr_2[j]
    return list(res.values())


if [-2, 1, 1] == arrays_mul([-1, 1], [2, 1]):
    print('Тест пройден')
else:
    print('Тест провален')

if [15, 19, 14, 40] == arrays_mul([3, 5], [5, -2, 8]):
    print('Тест пройден')
else:
    print('Тест провален')

if [2, -3, -2, 1, -2] == arrays_mul([-1, 1, 2], [-2, 1, -1]):
    print('Тест пройден')
else:
    print('Тест провален')

if [-7, -22, 7, -33, -12, 19, -6] == arrays_mul([-7, -1, 3, -1], [1, 3, -1, 6]):
    print('Тест пройден')
else:
    print('Тест провален')

if [10, -29, 8, 9, -16, 15] == arrays_mul([-5, 2, 1, -2, 3], [-2, 5]):
    print('Тест пройден')
else:
    print('Тест провален')
