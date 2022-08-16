Console.Clear();
Console.WriteLine("Написать программу копирования массива");
Console.Write("Введите данные массива (размер, минимальное и макисмальное значение, через пробел): ");
string SettingArr =  Console.ReadLine() ?? "0";
string[] SetArr = SettingArr.Split(" ");
int[] array = new int[Convert.ToInt32(SetArr[0])];
int[] newArray = new int[array.Length];

Console.WriteLine("Массив: ");
for (int i=0; i<Convert.ToInt32(SetArr[0]); i++)
{
    array[i] = new Random().Next(Convert.ToInt32(SetArr[1]),Convert.ToInt32(SetArr[2]));
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

for (int i=0; i<array.Length; i++)
    newArray[i] = array[i];

Console.WriteLine("Новый массив: ");
foreach (int k in newArray)
    Console.Write($"{k} ");


// по факту копирование массива можно заложить сразу в первый цикл for
// где мы присваиваем значения элементам первого массива
// (после 14ой строки добавить newArray[i] = array[i];)
// второй и третий циклы добавлены для наглядностви вывода в консоль сначала первого массива, затем нового


Console.Write("\n\nНажмите любую клавишу для продолжения...");
Console.ReadKey();

Console.Clear();
Console.WriteLine("Написать программу для операции 'произведение массива'");
Console.Write("Введите элементы первого массива через пробел): ");
string firstString =  Console.ReadLine() ?? "0";
Console.Write("Введите элементы второго массива через пробел): ");
string secondString =  Console.ReadLine() ?? "0";

string[] firstArray = firstString.Split(" ");
string[] secondArray = secondString.Split(" ");
int[] firstArr = new int[firstArray.Length];
int[] secondArr = new int[secondArray.Length];
int[] finalArr = new int[firstArray.Length + 1];

for (int n=0; n<firstArray.Length; n++)
{
    firstArr[n] = Convert.ToInt32(firstArray[n]);
    secondArr[n] = Convert.ToInt32(secondArray[n]);
}

for (int n=0; n<firstArray.Length; n++)
    for (int m=0; m<firstArray.Length; m++)
        finalArr[m+n] += firstArr[n]*secondArr[m];

Console.WriteLine("Произведение массивов: ");
foreach (int k in finalArr)
    Console.Write($"{k} ");