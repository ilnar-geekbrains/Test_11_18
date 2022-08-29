#include <stdio.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

//Получение массива от пользователя

int take(int* first, int a){
	printf("Write here your array:\n");
	for (int i=0;i<a;i++){
		scanf("%d", &first[i]);
	}
	return 0;
}

//Инициализация нулями массива результатов

int init(int s1, int s2, int* result){
	for (int i=0;i<s1+s2-1;i++){
		result[i]=0;
	}
	return 0;
}

//Перемножение архивов согласно правилам перемножения многочленов, индексы тут выступают аналогам степеней

int math(int* a, int* b, int s1, int s2, int* result){
	init(s1,s2,result);
	for (int i=0;i<s1;i++){
		for (int j=0;j<s2;j++){
			result[i+j]=result[i+j]+a[i]*b[j];
		}
	}
	return 0;
}

//Вывод результата на экран

int show(int s1, int s2, int* result){
	printf("Result of multiply is:\n");
	for (int i=0;i<s1+s2-1;i++){	
		printf("%d ", result[i]);
	}
	printf("\n");
	return 0;
}

int test(){
	int t1[2]={-1, 1};
	int t2[2]={2, 1};
	printf("Test arrays are:\n");
	for (int i=0;i<2;i++){
		printf("%d ", t1[i]);
	}	
	printf("\n");
	for (int i=0;i<2;i++){
		printf("%d ", t2[i]);
	}
	printf("\n");
	int res1[3];
	math(t1, t2, 2, 2, res1);
	show(2,2,res1);
	return 0;
}

int main(){
	test();
	int a,b;
	printf("What size first array is?\n");
	scanf("%d",&a);
	int* first = new int[a];
	take(first, a);
	printf("What size second array is?\n");
	scanf("%d",&b);
	int* second = new int[b];
	take(second, b);
	int* result = new int [a+b-1];
	math(first, second, a, b, result);
	show(a,b,result);
	return 0;
}