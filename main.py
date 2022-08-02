def multiply_arrays(poly1, poly2) -> list:
    res = [0] * (len(poly1) + len(poly2) - 1)
    for item1, i in enumerate(poly1):
        for item2, j in enumerate(poly2):
            res[item1 + item2] += i * j

    return res


if __name__ == '__main__':
    print(multiply_arrays([-1, 1], [1, 1]))
