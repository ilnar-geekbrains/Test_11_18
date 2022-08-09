// Метод создает массив. Атрибут size это размер массива, который задается пользователем. 

string [] CreateArray(int size)
{
    
    return new string[size];
    
}

/* Метод заполняет массив случайными символами. 
Атрибуты:
1) characterSet - набор символов из которых будет состять элемент массива. 
2) minSizeRow - минимальная длина элемента массива. 
3) maxSizeRow - максимальная длина элемента массива. 
*/
void FillArray(string[] array, string characterSet, int minSizeRow, int maxSizeRow)
{
    
    
    int size = array.Length;
    for(int j=0; j<size; j++)
    {
        int rand = new Random().Next(minSizeRow,maxSizeRow+1);
        for (int i = 0; i<rand; i++)
        {
            array[j] = array[j] + characterSet[new Random().Next(0,characterSet.Length)];
        }
    }


}

/* Основной Метод, который копирует массив.
Атрибуты:
1) existingArray - существующий массив, который нужно скопировать. 
*/

string [] CopyArray(string [] existingArray) 
{
    int size = existingArray.Length;
    string [] copyOfexistingArray = new string [size];
    
    for(int i = 0; i<size; i++)
        copyOfexistingArray[i] = existingArray[i];
    

    return copyOfexistingArray;
}


void TestCopyArray1()
{
    string [] test = {"er", "utw", "bjdh"};
    string [] copyTest = CopyArray(test);
    int count = 0;
    for(int i =0; i < test.Length; i++)
        {
            if(test[i]==copyTest[i])
                count+=1;
        }


    Console.WriteLine(test.Length==count);
}

void TestCopyArray2()
{
    string [] test = {"er", "utw", "bjdh"};
    string [] copyTest = {"er", "utw", "bjdh"};


    Console.WriteLine(CopyArray(test).Length==3);
}

/* Метод формирует строку, которую можно вывести на печать. 
Атрибуты:
array - массив из которого формируется строка. 
*/

string PrintArray(string [] array)
{
    string temp = string.Join(" ", array);
    string result = temp.Replace(" ","\", \"");
    return result;
}

/* 
Метод проверяет корректность ввода длины массива через рекурсию.  
*/

int CheckCorrectNum()
{
    Console.WriteLine("Size array should be a positive and greater than zero.");
    Console.Write("Input Size array: ");
    int arg = Convert.ToInt32(Console.ReadLine());

    if (arg >0) return arg;
    else 
    {
        return CheckCorrectNum();
        
    }
    
}

/* 
Метод проверяет корректность ввода строки через рекурсию. 
Строка не должна быть пустой.  
*/

string CheckCorrectString()
{
    Console.WriteLine("CharacterSet should not be is empty.");
    Console.Write("Input characterSet: ");
    string arg = Console.ReadLine();

    if (arg != String.Empty) return arg;
    else 
    {
        return CheckCorrectString();
        
    }
    
}

int CheckCorrectMinSizeRow()
{
    Console.WriteLine("Min Size Row array should be a positive and greater than zero.");
    Console.Write("Input min Size Row array: ");
    int arg = Convert.ToInt32(Console.ReadLine());

    if (arg >0) return arg;
    else 
    {
        return CheckCorrectMinSizeRow();
        
    }
    
}


/* 
Тесты основного метода. 
*/
Console.WriteLine("Tests of Method CopyArray: ");

TestCopyArray1();
TestCopyArray2();

Console.WriteLine("Main programm: ");


int size = CheckCorrectNum();

string characterSet = CheckCorrectString();

int minSizeRow = CheckCorrectMinSizeRow();

int CheckCorrectMaxSizeRow()
{
    Console.WriteLine("Max Size Row array should be a positive, greater than zero and greater than the min Size Row.");
    Console.Write("Input max Size Row array: ");
    int arg = Convert.ToInt32(Console.ReadLine());

    if (arg >0 && arg>minSizeRow) return arg;
    else 
    {
        return CheckCorrectMaxSizeRow();
        
    }
    
}

int maxSizeRow = CheckCorrectMaxSizeRow();

string [] array = CreateArray(size);
FillArray(array, characterSet, minSizeRow,maxSizeRow);

Console.WriteLine();
Console.WriteLine("Created initial array: ");
Console.WriteLine();
Console.WriteLine($"[\"{PrintArray(array)}\"]");
Console.WriteLine();


string [] CopyInitArray = CopyArray(array);

Console.WriteLine("Copy init array: ");
Console.WriteLine();
Console.WriteLine($"[\"{PrintArray(CopyInitArray)}\"]");









