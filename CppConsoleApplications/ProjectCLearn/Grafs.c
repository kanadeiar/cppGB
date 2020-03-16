#include "Grafs.h"

#define N 6
char filename[64] = "graf.txt";

void DoDeikstraGraf()
{
	int W[N][N];
	char buf[64];
	FILE * fin = fopen(filename, "r");
	if (!fin)
	{
		printf("Не удалось открыть файл%s!", filename);
		getchar();
		return;
	}
	int i=0;
	while (!feof(fin))
	{
		fgets(buf, _countof(buf), fin);
		int j=0;
		while (j < N)
		{
			W[i][j] = atoi(buf);
			char * p = strchr(buf, ' ');
			if (p!=NULL)
				strcpy(buf, p+1);
			j++;
		}
		i++;
	}
	fclose(fin);
	puts("Прочитанный граф:");
	for (int i=0; i<N; i++)
	{
		for (int j=0; j<N; j++)
			printf("%d ", W[i][j]);
		printf("\n");
	}
	getchar();

	for (int i=0; i<N; i++)
		for (int j=0; j<N; j++)
			if (W[i][j]==0)
				W[i][j] = 999;

	int from = 0;

	int Path[N];
	int Cost[N];
	int Known[N];
	for (int i=0; i<N; i++)
	{
		Known[i]=0;
		Cost[i]=999;
		Path[i]=-1;
	}
	Cost[from]=0;
	
	for (int k=0; k<N; k++)
	{
		int iMin = -1;
		int valMin = 999;
		for (int i=0; i<N; i++)
			if (Known[i] == 0 && Cost[i] < valMin)
			{
				valMin = Cost[i];
				iMin = i;
			}
		if (iMin == -1)
			continue;
		Known[iMin]=1;
		for (int i=0; i<N; i++)
			if (Known[i] == 0 && Cost[i] > Cost[iMin] + W[iMin][i])
			{
				Cost[i]=Cost[iMin]+W[iMin][i];
				Path[i]=iMin;
			}
	}


	puts("Кратчайшие пути:");
	for (int i=0; i<N; i++)
	{
		printf("До вершины %d: ", i+1);
		int v=i;
		while (Path[v]!=-1)
		{
			printf("%d ", Path[v]+1);
			v = Path[v];
		}
		printf("\n");
	}
	
}

void DoFloydWarshal()
{
	int MaxInt = 999999;
	int W[N][N] = {
    {0,2,4,0,0,0},
    {2,0,9,7,0,0},
    {4,9,0,8,1,0},
    {0,7,8,0,3,1},
    {0,0,1,3,0,2},
    {0,0,0,1,2,0},
	};
	for (int i=0; i<N; i++)
		for (int j=0; j<N; j++)
			if (W[i][j]==0)
				W[i][j]=MaxInt;
	//алгоритм Флойда-Уоршелла
	for (int k=0; k<N; k++)
		for (int i=0; i<N; i++)
			for (int j=0; j<N; j++)
				if (W[i][k]+W[k][j]<W[i][j])
					W[i][j]=W[i][k]+W[k][j];
	printf("%s", "      ");
	for (int i=0; i<N; i++)
		printf("%c(%d) ", 65+i, i);
	printf("\n");
	for (int i=0; i<N; i++)
	{
		printf("%c(%d)", 65+i, i);
		for (int j=0; j<N; j++)
			printf("%5d", (W[i][j]==MaxInt)? 0 : W[i][j]);
		printf("\n");
	}
}
