#include <stdio.h>
#include <windows.h>
#include <time.h>
#include <ctype.h>
#include <stdlib.h>
#include "Header.h"

#define N 33

int main(int argc, char * args[])
{
	Ru();
	
	long int arr[N + 1];
	arr[0] = 1;
	for (int i = 1; i<=N; i++)
		arr[i] = 0;
	int r = 0;
	for (int k = 2; k<=100; k++)
	{
		for (int i = 0; i<=N; i++)
		{
			int s = arr[i] * k + r;
			arr[i] = s % 1000000;
			r = s / 1000000;
		}
	}
	int i = N;
	while (!arr[i])
		i--;
	printf("%ld", arr[i]);
	for (int k = i-1; k>= 0; k--)
	{
		long int x = arr[k];
		long int M = 100000;
		while (M > 0)
		{
			printf("%d", x / M);
			x %= M;
			M /= 10;
		}
	}
	
	
	//int n = 1234;
	//long newN = 0;
	//while (n>0)
	//{
	//	newN = newN * 10 + n % 10;
	//	n /= 10;
	//}
	//printf("%ld\n", newN);	
	//int n = 5;
	//int newN = 0;
	//while (n > 0)
	//{
	//	newN = newN * 10 + n % 2;
	//	n /= 2;
	//}
	//printf("%d", newN);
	//int s = 0;
	//int n = 1979;
	//while (n > 0)
	//{
	//	s = s + n % 10;
	//	n /= 10;
	//}
	//printf("%d", s);

	getchar();
}

