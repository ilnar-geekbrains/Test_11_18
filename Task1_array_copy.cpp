#include <stdio.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

//Копирование массива a в массив b

int copy(int* a, int* b, int sze){
	printf("Result array is:\n");
	for (int i=0;i<sze;i++){
		b[i]=a[i];
		printf("%d ", b[i]);
	}
	printf("\n");
	return 0;
}

//Получение исходного массива

int take(int* a, int sze){
	printf("Show me your array:\n");
	for (int i=0;i<sze;i++){
		scanf("%d", &a[i]);
	}
	return 0;
}

//Сверка массивов

int tring(int* a, int* b, int sze){
	int fail=0;
	for (int i=0;i<sze;i++){
		if (b[i]!=a[i]) fail++;
	}
	if (fail==0) printf("Test passed\n");
	else printf("Test failed\n");
	return 0;
}

//Генерация произвольных массивов и проверка корректности копирования

int test(){
	int tst[5]={rand(), rand(), rand(), rand(), rand()};
	int probe[5];
	printf("Test array is:\n");
	for (int i=0;i<5;i++){
		printf("%d ", tst[i]);
	}
	printf("\n");
	copy(tst, probe, 5);
	tring(tst, probe, 5);
	return 0;
}

int main(){
	test();
	printf("What size your array is?\n");
	int a;
	scanf("%d",&a);
	int* origin = new int[a];
	take(origin, a);
	int* dubl = new int[a];
	copy(origin, dubl, a);
	return 0;
}