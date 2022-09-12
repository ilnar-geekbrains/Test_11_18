
################################### Multiply Two Arrays ################

def multiply_arrays(poly1,poly2):

    result = [0]*(len(poly1)+len(poly2)-1)

    for i in range(len(poly1)):
        for j in range(len(poly2)):
            result[i+j]=result[i+j]+poly1[i]*poly2[j]

    return result



####################################### TESTS ########################
array1 = [-1, 1]
array2 = [2, 1]

print ('The Function retruns {},  The expected answer is [-2, 1, 1]'.format ( multiply_arrays(array1, array2)) )