using Arrays;

// Тесты входных данных
Tests.Input_data_must_be_initialized(source: null, destination: null);
Tests.Input_data_must_be_initialized(source: new int[1], destination: null);
Tests.Input_data_must_be_initialized(source: null, destination: new int[1]);
Tests.Input_data_must_be_initialized(source: new int[1], destination: new int[1]);

Tests.Length_of_arrays_must_be_same(source: new int[1], destination: new int[2]);
Tests.Length_of_arrays_must_be_same(source: new int[2], destination: new int[2]);

// Тест на правильность копирования содержимого массива
int[] source = new[] {1, 2};
int[] copy = new int[2];
ArrayUtil.Copy(source, copy);
Tests.Arrays_must_have_the_same_contents(firstArray: source, secondArray: copy);

source = new[] {1, 2, 99999999};
copy = new int[3];
ArrayUtil.Copy(source, copy);
Tests.Arrays_must_have_the_same_contents(firstArray: source, secondArray: copy);