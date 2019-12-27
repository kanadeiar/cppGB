
#include <stdio.h>
#include <math.h>

#define ARR_SIZE 10

void printSquared(float x1, float x2, int result)
{
	switch (result)
	{
	case 1:
		printf_s("Два корня %.2f %.2f\n", x1, x2);
		break;
	case 0:
		printf_s("Один корень %.2f\n", x1);
		break;
	case -1:
		printf_s("Нет корней\n");
		break;
	}
}

int calcSquareEquality(int a, int b, int c, float *x1, float *x2)
{
	int d = b * b - 4 * a * c;
	if (d > 0)
	{
		*x1 = ((float)-b + (float)sqrt(d)) / 2.0f * (float)a;
		*x2 = ((float)-b - (float)sqrt(d)) / 2.0f * (float)a;
		return 1;
	}
	if (d == 0)
	{
		*x1 = *x2 = ((float)-b + (float)sqrt(d)) / 2.0f * (float)a;
		return 0;
	}
	return -1;
}

void Task1(void)
{
	printf_s("Task1\n");

	float x1;
	float x2;
	int result = calcSquareEquality(1, 8, 12, &x1, &x2);
	printSquared(x1, x2, result);
	result = calcSquareEquality(5, 3, 7, &x1, &x2);
	printSquared(x1, x2, result);
	result = calcSquareEquality(1, -6, 9, &x1, &x2);
	printSquared(x1, x2, result);
}



void Task2(void)
{
	printf_s("Task2\n");
	int arr[10] = {5, 2, 2, 2, 3, 5, 3, 2, 9, 4};
	

	
}




