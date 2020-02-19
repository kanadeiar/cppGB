#include <stdio.h>
#include <windows.h>
#include <time.h>
#include <ctype.h>
#include <stdlib.h>
#include "Header.h"


#include "MQueue.h"



int main(int argc, char * args[])
{
	Ru();
	TQueue * queue = (TQueue*) malloc(sizeof(TQueue));
	MQInit(queue);
	for (int i = 0; i<9; i++)
		MQPush(queue, i);
	while (!MQEmpty(queue))
		printf("%d\n", MQPop(queue));
	puts("Again:");
	for (int i = 0; i<9; i++)
		MQPush(queue, i*i);
	while (!MQEmpty(queue))
		printf("%d\n", MQPop(queue));
	
	getchar();
}

