#include <stdio.h>
#include <windows.h>
#include <time.h>

#include "Header.h"

int main(int argc, char * args[])
{
	Ru();

	char s[80] = "Кот мяукает!";
	char s1[30];
	strcpy( s1, s+4);
	strcpy(s+4, "громко ");
	strcat(s, s1);
	puts(s); //Кот громко мяукает!

	getchar();
	return 0;
}

