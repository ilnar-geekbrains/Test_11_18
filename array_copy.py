def array_copy():
    original_array = list(map(int, input().split()))
    copied_array = original_array.copy()
    print(original_array is copied_array)  # вернет False, т.е. списки разные


def main():
    array_copy()
    return 0


main()
