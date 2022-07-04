def check_array(x1,x2):
    if x1 == x2:
        print(f'Первый массив:{x1}, второй массив:{x2}. Копирование завершено!')
    else:
        print('Копирование не удалось.')
    return

n=int(input())      # Количество строк в массиве
array=[]
new_array=[]
for i in range(n):
    array.append(list(map(int, input().split())))
new_array=array.copy()
check_array(array,new_array)