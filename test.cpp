#include <iostream>
#include <array>

using namespace std;

// Задача 1
//-------------------------------------------------------------
// простое и самое оптимальное решение
void test1()
{
	array<int, 5> arr = { 1, 2, 3, 4, 5 };
	array<int, 5> arrCopy = arr;

	cout << "Result: " << endl;
	for (int num : arrCopy)
		cout << num << " ";
}

// более наглядное решение, но требующее больше памяти
void test1_2()
{
	array<int, 5> arr = { 1, 2, 3, 4, 5 };
	array<int, 5> arrCopy = {};

	cout << "Result: " << endl;
	for (int i = 0; i < arr.size(); i++)
	{
		int num = arr[i];
		arrCopy[i] = num;

		cout << arrCopy[i] << " ";
	}
}

// Задача 2
//-------------------------------------------------------------

void test2()
{
	array<int, 3> polynom1 = { 2, 4, 6 };
	array<int, 2> polynom2 = { 1, 3 };

	const int newSize = polynom1.size() + polynom2.size() - 1;
	array<int, newSize> result = {};

	for (int i = 0; i < polynom1.size(); i++)
	{
		for (int j = 0; j < polynom2.size(); j++)
		{
			result[i + j] += polynom1[i] * polynom2[j];
		}
	}

	cout << "Result: " << endl;
	for (int num : result)
		cout << num << " ";
}


int main()
{
	return 0;
}
