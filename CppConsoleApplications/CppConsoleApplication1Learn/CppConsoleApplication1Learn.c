#include <locale.h>
#include <stdio.h>
#include <math.h>

#include "CppConsoleApplication1Learn.h"

#define SIZE 10

int main(int argc, const char* argv[])
{
	setlocale(LC_ALL, "russian");
	printf_s("Привет мир");

	printf_s("Введите любое число:");
	int a;
	scanf_s(" %d", &a);
	printf_s("\nСумма = %d\n", sum(a, 50));

	int num = 71;
	printf_s("Введите любое число:");
	scanf_s(" %d", &num);	
	printf_s("Введенное целое число %d %sявляется простым", num, isPrime(num)? "" : "не " );
	

	return 0;
}



