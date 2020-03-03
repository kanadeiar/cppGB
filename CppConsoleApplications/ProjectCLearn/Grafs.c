#include "Grafs.h"

#define N 6
int W[N][N];

void DoGraf()
{
	FILE * fin = fopen("graf.txt", "r");
	char str[128];
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
				if (W[i][j] == 0)
					W[i][j] = 999;
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
		puts("Не удалось открыть файл.");
		return;
	}
	puts("Граф:");
	for (int i=0; i<N; i++)
	{
		for (int j=0; j<N; j++)
			printf("%3d ", W[i][j]);
		printf("\n");
	}
	

	int Active[N];
	int Route[N];
	int Peak[N];
	int min, kMin = 0;
	for (int i=0; i<N; i++)
	{
		Active[i] = 1;
		Route[i] = W[0][i];
		Peak[i] = -1;
	}
	Active[0] = 0;
	for (int i=0; i<N-1; i++)
	{
		min = 999;
		for (int j=0; j<N; j++)
			if (Active[j]==1 && Route[j]<min)
			{
				min = Route[j];
				kMin = j;
			}
		Active[kMin]=0;
		for (int j=0; j<N; j++)
			if (Active[j]==1 && Route[j]>Route[kMin]+W[j][kMin] && W[j][kMin]!=999)
			{
				Route[j] = Route[kMin]+W[j][kMin];
				Peak[j]=kMin;
			}
	}
	int i = N-1;
	while (i!=-1)
	{
		printf("%d ", i+1);
		i=Peak[i];
	}
	printf("1\n");
}