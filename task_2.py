"""
Задача №2 с элементами математики. 
Написать программу для операции "произведение массивов". 
Сама операция определяется так, как будто элементы массива - это коэффициенты полинома. 
Соответственно, произведение массивов - должно дать новый массив, 
коэффициенты которого соответсвуют нужному полиному.

Например, возьмем полином (x - 1) и полином (x + 2). 
Их можно представить в виде массивов [-1, 1] и [2, 1] соответственно. 
Индекс элемента в массиве соответствует степени x при этом коээфициенте, 
т.е. полином (x - 1) можно переписать как (-1 * x^0 + 1 * x^1), 
таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].

По указанному правилу произведение массивов [-1, 1] и [2, 1] 
должно быть равно [-2, 1, 1], т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).
"""

from task_1 import is_arrays_equal

def linear_convolution(arr1, arr2):
    """Функция рассчета линейной свертки двух массивов."""
    
    N_out = len(arr1) + len(arr2)
    result = []
    
    for n in range(1, N_out):
        summ = 0
        for i, j in zip(range(n), range(n-1, -1, -1)):
            if i < len(arr1) and j < len(arr2):
                summ += arr1[i] * arr2[j]
        result.append(summ)
        
    return result

def test_linear_convolution():
    test_table = [
        [[-1, 1], [2, 1], [-2, 1, 1]],
        [[1, 2, 3], [4, 5, 6], [4, 13, 28, 27, 18]],
        [[2, 1, 3, -1], [-1, 1, 2], [-2,  1,  2,  6,  5, -2]],
        [[-1, 1, 2], [2, 1, 3, -1], [-2,  1,  2,  6,  5, -2]]
    ]
    for arr1, arr2, result in test_table:
        # print(f"linear_convolution({arr1},  {arr2}) = {linear_convolution(arr1, arr2)}")
        assert is_arrays_equal(linear_convolution(arr1, arr2), result), "The arrays are not equal."

if __name__ == '__main__':
    print("Test linear_convolution: ", end="")
    test_linear_convolution()
    print("OK")