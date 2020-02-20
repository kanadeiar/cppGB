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

	//подготовка графа
	for (int i=0; i<N; i++)
		for (int j=0; j<N; j++)
			if (W[i][j]==0)
				W[i][j]=99;
	//остовное дерево
	int col[N];
	int ostov[N-1][2];
	for (int i = 0; i<N; i++)
		col[i] = i; //раскрашивание дерева в разные цвета
	int iMin, jMin;
	for (int k=0; k<N-1; k++)
	{
		int min = 99999;
		for (int i=0; i<N; i++)
			for (int j=0; j<N; j++)
				if (col[i]!=col[j] && W[i][j]<min) //нахождение ребра с минимальным весом
				{
					iMin = i;
					jMin = j;
					min = W[i][j];
				}
		ostov[k][0]=iMin; //добавление ребра в список выбранных
		ostov[k][1]=jMin;
		int c = col[jMin];
		for (int i=0; i<N; i++)
			if (col[i]==c)
				col[i]=col[iMin]; //перекрашивание вершин
	}
	//вывод остова на экран
	for (int i=0; i<N-1; i++)
		printf("(%d,%d)\n", ostov[i][0]+1, ostov[i][1]+1);


	
};


