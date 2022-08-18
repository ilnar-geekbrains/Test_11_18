def isAtom(elem) -> bool:
    """
    Функция проверяет объект на атомарность.
    """
    if isinstance(elem, (str, int, float, bool)): 
        return True
    return False

def copyofDeepCopy(array: list) -> list: # как я понял, мне нужно было написать глубокую копию de novo
    """
    Функция рекурсивно обходит список и возвращает его глубокую копию.
    """
    new = []

    for elem in array:
        if isAtom(elem):
            new.append(elem)
        else:
            new.append(copyofDeepCopy(elem))

    return new
