from itertools import combinations_with_replacement

def product_of_polynom(poly_1, poly_2):
    result = []
    for (index1, coef1) in enumerate(poly_1):
        for (index2, coef2) in enumerate(poly_2):
            index = index1 + index2
            coef = coef1 * coef2
            if index == len(result):
                result.append(coef)
            else:
                result[index] += coef
    return result


if __name__ == "__main__":
    data = [
            [[-1, 1], [2, 1], [-2, 1, 1]],
            ]
    for poly1, poly2, result in data:
        try:
            assert product_of_polynom(poly1, poly2) == result
        except AssertionError:
            print('Test failed')
            print(f'Returns {product_of_polynom(poly1, poly2)}, but must be {result}')
        finally:
            print('All tests is OK')
