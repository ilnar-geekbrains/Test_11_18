def multiplication_of_arrays(first_arr, second_arr):
  f_len = len(first_arr)
  s_len = len(second_arr)
  res_arr = [0]*(f_len + s_len - 1)
  for i in range(f_len):
    for j in range(s_len):
      res_arr[j+i] += first_arr[i]*second_arr[j]
  return res_arr
#Пример
inp1 = [-1, 1]
inp2 = [-1, 1]
print(multiplication_of_arrays(inp1, inp2))

#проверка 1
if multiplication_of_arrays([-1, 1], [2, 1]) == [-2, 1, 1]:
  print("Test 1 is", True)
else:
  print("Test 1 is", False)

#проверка 2
if multiplication_of_arrays([-1, 1, 0 , 4], [-1, 1, 3, 7]) == [1, -2, -2, -8, 11, 12, 28]:
  print("Test 2 is", True)
else:
  print("Test 2 is", False)

#можно задать списки через ввод, но не знал в каком формате он