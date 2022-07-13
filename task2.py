def polynomial_multiplication(polynom1, polynom2):
    deg = len(polynom1) + len(polynom2)
    multiple_polynom = [0] * (deg-1)
    
    for i in range(len(polynom1)):
        for j in range(len(polynom2)):
            multiple_polynom[i + j] += polynom1[i] * polynom2[j]
            
    return multiple_polynom


def polynomial_multiplication_tests():
    poly1_test1 = [2]
    poly2_test1 = [3]
    assert polynomial_multiplication(poly1_test1, poly2_test1) == [6], "Multiplication of polynomials of the first degree failed"
    
    poly1_test2 = [-1, 1]
    poly2_test2 = [1, 1]
    assert polynomial_multiplication(poly1_test2, poly2_test2) == [-1, 0, 1], "Multiplication of polynomials of the equal degree failed"
    
    poly1_test3 = [-1, 1, 1]
    poly2_test3 = [1, 1]
    assert polynomial_multiplication(poly1_test3, poly2_test3) == [-1, 0, 2, 1], "Multiplication of polynomials of different degrees failed"
    
    print("All tests are passed")

if __name__ == "__main__":
    polynomial_multiplication_tests()

