using System;


//**Задача №1.* *Написать программу для копирования массива.

/// <summary>
/// Класс содержит два основных метода копирования массива
/// Добавлять тесты смысла не вижу... слишком маленький код
/// </summary>
public static class ClassCopyArreyExample
{

	//Изначально все массивы в C# наследуются от класса Arrey, а он ссылочный.
	//При попытке прировнять массивы, новому массиву будет передана ссылка на массив.
	//Возможно оставить содержимое массива источника массиву получателю, но только при уничтожении ссылки от массива источника.
	//Для этого нужно просто заново проинициализировать массив источник.

	//=====================================================================================================================
	//                                     Провекрка в консольном приложении
	//=====================================================================================================================
	//
	//int[] intArrey = new int[3] { 0, 1, 2 };
	//
	//var outArrey1 = ClassCopyArreyExample.CopyArreyStandartToola(intArrey);
	//
	//string[] stringArrey = new string[4] { "q", "qw", "qwe", "qwerty" };
	//
	//var outArrey2 = ClassCopyArreyExample.CopyArreyNaive(stringArrey);
	//
	//=====================================================================================================================

	/// <summary>
	/// Метод копирует массив входной и возвращает массив его копию
	/// Копирование производится стандартными методами
	/// </summary>
	/// <param name="inputArrey">Входной массив</param>
	/// <returns>Копию входного массива</returns>
	public static object[] CopyArreyStandartToola(params object[] inputArrey)
	{
		//Объявляем новый массив равный по длине входному
		object[] outputArrey = new object[inputArrey.Length];

		//Копируем массив
		inputArrey.CopyTo(outputArrey, 0);

		//Возвращаем
		return outputArrey;
	}

	/// <summary>
	/// Метод копирует массив входной и возвращает массив его копию
	/// Копирование производится самым наивным методом(поэлементно)
	/// </summary>
	/// <param name="inputArrey">Входной массив</param>
	/// <returns>Копию входного массива</returns>
	public static object[] CopyArreyNaive(params object[] inputArrey)
	{
		//Объявляем новый массив равный по длине входному
		object[] outputArrey = new object[inputArrey.Length];

		//Копируем массив проходя все элементы
		for (int i = 0; i < inputArrey.Length; i++)
		{
			//Копируем элемент из входного массива в выходной
			outputArrey[i] = inputArrey[i];
		}

		//Возвращаем
		return outputArrey;
	}
}
