#include <stdio.h>
#include <windows.h>
#include <time.h>
#include <ctype.h>
#include "Header.h"

int irand(int from, int to)
{
	return from + rand() % (to - from);
}

int main(int argc, char * args[])
{
	Ru();
	
	int arr[10][10];
	for (int i=0; i<7; i++)
		for (int j=0; j<7; j++)
			arr[i][j] = rand() % 10;

	int bord;
	for (int i=0; i<7; i++)
	{
		if (i <= 7/2)
			bord = i;
		else
			bord = 6-i;
		for (int j=3-bord; j<=3+bord; j++)
			arr[i][j] = 99;
	}





	
	
	for (int i=0; i<7; i++)
	{
		for (int j=0; j<7; j++)
			printf("%3d ", arr[i][j]);
		printf("\n\n");
	}
	getchar();
	return 0;
}

