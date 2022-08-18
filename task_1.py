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
    
if __name__ == '__main__':
    array = [1, 2, 'a', (True, 1.1), [1, 2, False]]
    array2 = copyofDeepCopy(array)
    
    
    assert array is not array2 # id разные
    assert array[-1] is not array2[-1] # для изменяемых создаётся новый инстанс

    
    
    assert array[1] is not array2[1] # а вот тут был неизменяемый объект
    # неизменяемые объекты нет смысла дублировать, так что тут должна быть ошибка, всё ок

    # assert array[-1][1] is not array2[-1][1]
    # это тоже вызвало было ошибку, потому что внутри нового списка ссылка на тот же неизменяемый объект


