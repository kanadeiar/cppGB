#include "CppConsoleApplication1Learn.h"

#include <locale.h>
#include <stdio.h>
#include <time.h>


//#define ARRAY_LENGTH 10
//#define NUMBERS_AMOUNT 100000



int main(int argc, const char* argv[])
{
	setlocale(LC_ALL, "russian");
	printf_s("Программа на С\n***********************\n");
	Task1();
	

	
	return 0;
	//srand(time(NULL));
	//int freq[10] = {0};
	//int a = 0;
	//for (int i = 0; i < NUMBERS_AMOUNT; i++)
	//{
	//	a = rand() % ARRAY_LENGTH;
	//	freq[a]++;
	//}
	//printf_s("Массив указатель = %p\n", freq);
	//for (int i = 0; i < ARRAY_LENGTH; i++)
	//{
	//	printf_s("Число %d получено %d раз ", i, *(freq + i));
	//	printf_s("Указатель элементов массива = %p\n", freq + i);
	//}
	//
	//int arr2[ARRAY_LENGTH];
	//for (int i = 0; i < ARRAY_LENGTH; i++)
	//{
	//	printf_s("Введите значение номер %d:> ", i);
	//	scanf_s(" %d", arr2 + i);
	//}
	//printf_s("Среднее значение равно = %f\n", average(arr2, ARRAY_LENGTH));
	//printf_s("Массив:");
	//printArr(arr2, ARRAY_LENGTH);
	//printf_s("\n");
}



