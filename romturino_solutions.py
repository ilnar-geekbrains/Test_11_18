import copy
import numpy

array_copy = lambda array: copy.deepcopy(array)



nums1 = [0, 1, 2, 3, 4, 5]
nums2 = (0, 1, 2, 3, 4)
nums3 = {0, 1, 2, 3}
nums4 = {0: 0, 1: 1}
nums5 = numpy.arange(5)
print(type(nums1), type(nums2), type(nums3), type(nums4), type(nums5))
if nums1 == array_copy(nums1):
    print('списки идентичны')
if nums2 == array_copy(nums2):
    print('кортежи идентичны')#это происходит с оговоркой, что оба кортежа ссылаются на одну ячейку памяти, ибо иммутабельны
if nums3 == array_copy(nums3):
    print('множества идентичны')
if nums4 == array_copy(nums4):
    print('словари идентичны')
if nums5.all() == array_copy(nums5).all():
    print('массивы numpy идентичны')
######################################################################################
def arr_mul(arr1, arr2):
    new_arr = []
    polinom_sum = 0
    for i in range(len(arr1)):
        for j in range(len(arr2)):
            if i == j:
                if polinom_sum:
                    new_arr.append(polinom_sum)
                new_arr.append(arr1[i] * arr2[j])
            else:
                polinom_sum += arr1[i] * arr2[j]
    return new_arr




#(x-1)(x+2) = (-1+x)(2+x) = -2+x+x^2
if arr_mul([-1,1], [2,1]) == [-2,1,1]:
    print(f'Всё работает. Функция сказала, что [-1,1] * [2,1] = {arr_mul([-1,1], [2,1])}')
#(x-5)(3x-2) = 3x^2 - 17x + 10
if arr_mul([-5, 1], [-2, 3]) == [10,-17, 3]:
    print(f'Всё работает. Функция сказала, что [-5,1] * [-2,3] = {arr_mul([-5, 1], [-2, 3])}')
#(2x-5)(16x-9) = (-5+2x)(-9+16x) = 32x^2 - 98x + 45
if arr_mul([-5, 2], [-9, 16]) == [45, -98, 32]:
    print(f'Всё работает. Функция сказала, что [-5,2] * [-9,16] = {arr_mul([-5, 2], [-9, 16])}')