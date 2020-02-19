#include <stdio.h>
#include <windows.h>
#include <time.h>
#include <ctype.h>
#include <stdlib.h>
#include "Header.h"


#include "MStack.h"

const char L[5] = "([{<";
const char R[5] = ")]}>";
char str[80];
MStack stack;

void do_work(int* error)
{
	for (int i = 0; i<strlen(str); i++)
	{
		char * p = strchr(L, str[i]);
		if (p!=NULL)
			MPush(&stack, str[i]);
		p = strchr(R, str[i]);
		if (p!=NULL)
		{
			if (MEmpty(stack))
				*error = 1;
			else
			{
				char c = MPop(&stack);
				char * pr = strchr(L, c);
				if (p-R != pr-L)
					*error = 1;
			}
			if (*error)
				break;
		}
	}
}

int main(int argc, char * args[])
{
	Ru();
	MInit(&stack);
	int error = 0;

	strcpy(str, "{<>()}[]");
	printf("Строка: %s\n", str);
	do_work(&error);
	if (error)
		puts("Скобки расставлены неправильно!");
	else
		puts("Скобки расставлены правильно!");
	
	strcpy(str, "{]");
	printf("Строка: %s\n", str);
	do_work(&error);
	if (error)
		puts("Скобки расставлены неправильно!");
	else
		puts("Скобки расставлены правильно!");
	
	getchar();
}

