#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define N 6


void DoGraf1()
{
	int W[N][N];
	char str[64];
	FILE * fin = fopen("graf.txt", "r");
	if (fin)
	{
		int i = 0;
		while (!feof(fin))
		{
			fgets(str, _countof(str), fin);
			int j = 0;
			while (j < N)
			{
				W[i][j] = atoi(str);
				char * p = strchr(str, ' ');
				if (p!=NULL)
					strcpy(str, p+1);
				j++;
			}
			i++;
		}
		fclose(fin);
	}
	else
	{
		puts("Не удалось открыть файл для чтения!");
	}
};


