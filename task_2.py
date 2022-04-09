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
    assert product_of_polynom([-1, 1], [2, 1]) == [-2, 1, 1]
