﻿#include "CppConsoleApplication1Learn.h"

#include <locale.h>
#include <stdio.h>
#include <time.h>




int main(int argc, const char* argv[])
{
	setlocale(LC_ALL, "russian");
	printf_s("Привет, Мир!\n");

	

	getchar();
	return 0;
}


