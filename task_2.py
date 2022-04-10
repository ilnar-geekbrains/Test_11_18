from itertools import combinations_with_replacement

def product_of_polynom(poly_1, poly_2):
    """
    This function computes the coefficients of 2 producted polynomes.
    poly_1 and poly_2 are lists of coefficients.
    Returns a list of resulted coefficients.

    Example:
    For polynomes x-1 and 2x+1 resulted polynome is x^2+x-2.
    Original lists are [-1, 1] and [2, 1].
    Resulted list is [-2, 1, 1]

    If any of original list is [] or [0] - the resulted list will be [0]
    """

    if not poly_1:
        poly_1 = [0]
    if not poly_2:
        poly_2 = [0]

    result = []
    for (index1, coef1) in enumerate(poly_1):
        for (index2, coef2) in enumerate(poly_2):
            index = index1 + index2
            coef = coef1 * coef2
            if index == len(result):
                result.append(coef)
            else:
                result[index] += coef
    for i in range(len(result) - 1):
        if result[-1] == 0:
            result.pop(-1)
    return result


if __name__ == "__main__":
    data = [
            [[-1, 1], [2, 1], [-2, 1, 1]],
            [[2, 3, 1], [1, -2, 0, -1], [2, -1, -5, -4, -3, -1]],
            [[0], [1, 2, 3, 4, 5], [0]],
            [[], [], [0]],
            [[], [-4, -2, -8], [0]]
            ]
    try:
        for poly1, poly2, result in data:
            assert product_of_polynom(poly1, poly2) == result
        print('All tests is OK')
    except AssertionError:
        print('Test failed')
        print(f'Returns {product_of_polynom(poly1, poly2)}, but must be {result}')
