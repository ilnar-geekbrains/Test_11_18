/* 
Так как в условии задачи почти нет конкретики сформируем следующие допущенния:
1) Перемножются только два полинома. 
2) Каждый из полиномов состоит из двух коэффициентов. 
3) Степень полинома не превышает 1. 

*/


int [] FillPol()
{
    int [] array = new int[2];
    
    for(int i = 0; i<2; i++)
    {
        Console.Write($"Input coefficient x^{i}: ");
        int arg = Convert.ToInt32(Console.ReadLine());
        array[i] = arg;
    }

    return array;

   
}

int [] FindPolRes(int[] array1, int[] array2)
{

    int [] resultArray = new int[3];

    resultArray[0] = array1[0]*array2[0];
    resultArray[1] = array1[1]*array2[0] + array1[0]*array2[1];
    resultArray[2] = array1[1]*array2[1];

    return resultArray;
}


string PrintArray(int [] array)
{
   
    return string.Join(", ", array);
}

/* 
Тесты основного метода. 
*/

void TestFindPolRes1()
{
    int[] array1 = {1,3};
    int[] array2 = {-4,2};

    int [] test = {-4, -10, 6};

    int [] resPol = FindPolRes(array1, array2);

    int count = 0; 

    for(int i =0; i < resPol.Length; i++)
        {
            if(test[i]==resPol[i])
                count+=1;
        }


    Console.WriteLine(test.Length==count);

}

void TestFindPolRes2()
{
    int[] array1 = {1,3};
    int[] array2 = {-4,2};

    int [] resPol = FindPolRes(array1, array2);

    Console.WriteLine(resPol.Length==3);

}



Console.WriteLine("Tests of Method CopyArray: ");

TestFindPolRes1();
TestFindPolRes2();
Console.WriteLine("Input first polynomial: ");
int [] arrayFirst = FillPol();


Console.WriteLine("Input second polynomial: ");
int [] arraySecond = FillPol();

Console.WriteLine();

Console.WriteLine("Result polynomial: ");

int [] resultArray = FindPolRes(arrayFirst,arraySecond);

Console.WriteLine($"[{PrintArray(resultArray)}]");

