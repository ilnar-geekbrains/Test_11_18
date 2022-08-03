
def multiply_polinoms_simple(first_polinom: list, second_polinom: list) -> list:
    """multiplies (ax - b) like polinoms"""
    output = [0, 0, 0]
    for i, number_in_first in enumerate(first_polinom):
        for j, number_in_second in enumerate(second_polinom):
            output[i+j] += number_in_first * number_in_second
    return output
