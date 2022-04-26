//Подключение библиотек
#include <iostream>
#include <cstdlib>
#include <algorithm>
using namespace std;

//функция для копирования массива
int *copyArray(int *array, int size){
  int * copiedArray = new int[size];  //создание  нового массива 
  for (int i=0; i<size; i++){
    copiedArray[i] = array[i];
  }
  return copiedArray; //возвращение данных массива
}

//функция для генерации нового массива и его заполнения значениями от 0 до 9
int *generateArray(){
  int * generateArray = new int[7];
  for(int i=0; i<7; i++){
     generateArray[i]= 1 + rand()%9;
   }
   return generateArray;
}

//проверка корректности заполнения массива данными
bool Changes(int *generateArray, int *copiedArray)
{
    sort(generateArray, generateArray + 7);
    sort(copiedArray, copiedArray + 7);

    for (int i = 0; i < 7; ++i)
    {
        if (generateArray[i] != copiedArray[i])
            return false;
    }

    return true;
}

int main()
{
  srand(time(NULL)); // "обнуление" функции рандом для обеспечения заполнения новыми данными при перезапуске программы
  for (int i = 0; i < 7; i++){
    int *userArray = generateArray(); //новый массив запоняется вызовом функции
    int *copiedArray = copyArray(userArray,7);
    cout << "\n" << i+1 << ".Сгенерированный массив: ";

    for (int i = 0; i < 7; ++i) {
      cout << userArray[i] << " ";
    }

    cout << endl;
    cout << "\n" << i+1 << ".Скопированный массив: ";

    for (int i = 0; i < 7; ++i) {
      cout << copiedArray[i] << " ";
    }

    cout << endl;
    if (Changes(userArray,copiedArray) == true){
      cout << "\n" << i+1 << ".Тест пройден\n";
    }
    else{
      cout << "\n" << i+1 << ".Ошибка данных\n";
    }
    delete[] userArray; //очистка данных
    delete[] copiedArray;
  }
  return 0;
}