# Написать программу для операции "произведение массивов".
# Сама операция определяется так, как будто элементы массива - это коэффициенты полинома.
# Соответственно, произведение массивов - должно дать новый массив, коэффициенты которого
# соответсвуют нужному полиному.

polin1 = [1,2,-1]    #x^2+2*x-1
polin2 = [1,1,0]   #x^2+x

def multiply_polinoms(pol1,pol2):
    len_polin1 = len(pol1)    #count len of polin1
    len_polin2 = len(pol2)    #count len of polin2
    result = [0]*(len_polin1+len_polin2-1)  #create new list for result

    for i in range(0,len_polin1):
        for j in range(0,len_polin2):
            result[i+j] += pol1[i]*pol2[j]      #write result of multiplication in new list

    return result

print(multiply_polinoms(polin1, polin2))