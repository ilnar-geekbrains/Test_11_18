array_1=list(map(int, input().split()))
array_2=list(map(int, input().split()))
array_3=[]

# Заполняем новый массив нулями
for i in range(len(array_1)+len(array_2)-1):
    array_3.append(0)

for i in range(len(array_1)):
    for j in range(len(array_2)):
        array_3[i+j]+=array_1[i]*array_2[j]
print(f'{array_1} * {array_2} = {array_3}')