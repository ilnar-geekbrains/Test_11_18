#include <iostream>
#include <cstdlib>
#include <algorithm>
using namespace std;


int *copyArray(int *array, int size){
  int * copiedArray = new int[size];
  for (int i=0; i<size; i++){
    copiedArray[i] = array[i];
  }
  return copiedArray;
}

int *generateArray(){
  int * generateArray = new int[5];
  for(int i=0;i<5;i++){
     generateArray[i]= 1 + rand()%9;
   }
   return generateArray;
}

bool isPermutation(int *generateArray, int *copiedArray)
{
    sort(generateArray, generateArray + 5);
    sort(copiedArray, copiedArray + 5);

    for (int i = 0; i < 5; ++i)
    {
        if (generateArray[i] != copiedArray[i])
            return false;
    }

    return true;
}

int main()
{
  srand(time(NULL));
  for (int i =0; i<5; i++){
    int *userArray = generateArray();
    int *copiedArray = copyArray(userArray,5);
    cout << "\n" << i+1 << ".Сгенерированный массив: ";

    for (int i = 0; i < 5; ++i) {
      cout << userArray[i] << " ";
    }

    cout << endl;
    cout << "\n" << i+1 << ".Скопированный массив: ";

    for (int i = 0; i < 5; ++i) {
      cout << copiedArray[i] << " ";
    }

    cout << endl;
    if (isPermutation(userArray,copiedArray) == true){
      cout << "\n" << i+1 << ".Test accepted\n";
    }
    else{
      cout << "\n" << i+1 << ".Test refused\n";
    }
    delete[] userArray;
    delete[] copiedArray;
  }
  return 0;
}
