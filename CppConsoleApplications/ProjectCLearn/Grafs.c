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

#define MAXN 45 //наибольшее представляющее интерес число n
#define UNKNOWN -1 //пустая ячейка
long f[MAXN+1]; //массив для хранения вычисленных значений fib
long fib_c(int n)
{
	if (f[n] == UNKNOWN)
		f[n] = fib_c(n-1) + fib_c(n-2);
	return f[n];
}
long fib_c_driver(int n)
{
	int i;
	f[0]=0;
	f[1]=1;
	for (i=2; i<=n; i++)
		f[i]=UNKNOWN;
	return fib_c(n);
}
void BestFibonacci()
{
	long num = fib_c_driver(6);
	printf("val = %d\n", num);
}


long fib_u(int n)
{
	int i;
	long back2=0;
	long back1=1;
	long next;
	if (n==0) return 0;
	for (i=2; i<=n; i++)
	{
		next=back1+back2;
		back2=back1;
		back1=next;
	}
	return back1;
}
void RetFibonacci()
{
	long n = fib_u(6);
	printf("val = %d\n", n);
}
