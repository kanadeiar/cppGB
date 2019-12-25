#include <locale.h>
#include <stdio.h>
#include <math.h>

#include "CppConsoleApplication1Learn.h"

#define SIZE 10

int main(int argc, const char* argv[])
{
	setlocale(LC_ALL, "russian");
	printf_s("Привет мир");

	
	
	getchar();
	return 0;
}



