class Array(list):
    def __mul__(self, other):
        if not isinstance(other, self.__class__):
            raise TypeError(f'object must be {self.__class__.__name__} type')

        self_dict = {k: v for k, v in enumerate(self)}
        other_dict = {k: v for k, v in enumerate(other)}
        result = {}
        for rank_self, el in self_dict.items():
            for rank_other, other_el in other_dict.items():
                rank = rank_self + rank_other
                if result.get(rank) is None:
                    result[rank] = el * other_el
                else:
                    result[rank] += el * other_el

        return [value for value in result.values()]


def mul_arrays(array_1: list, array_2: list):
    if not isinstance(array_1, list) or not isinstance(array_1, list):
        raise TypeError(f'function can multiply only lists')
    return Array(array_1) * Array(array_2)


def main():
    array_1 = input(
        'Введите первый массив как последовательность чисел через пробел. Пример: -1 1\n'
    )
    array_1 = [float(el) for el in array_1.split()]
    array_2 = input(
        'Введите второй массив как последовательность чисел через пробел. Пример: 2 1\n'
    )
    array_2 = [float(el) for el in array_2.split()]
    print(mul_arrays(array_1, array_2))


if __name__ == '__main__':
    main()
