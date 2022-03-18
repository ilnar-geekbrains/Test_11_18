// копирование массива

using System;

class ArrayCopy {
    static void Main(string[] args) {
		var arr = new[] { "bla", "blo", "ble" };
		int len = arr.Length;
		var copy = new string[len];

		arr.CopyTo(copy, 0);

		foreach (var item in copy) {
			Console.WriteLine(item);
		}
    }
}