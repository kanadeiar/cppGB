#pragma once
#include <stdlib.h>
#include <stdio.h>
#define SIZE_Q 10

typedef struct
{
	int data[SIZE_Q];
	int size;
	int head;
	int tail;
} TQueue;
void MQInit(TQueue * queue);
void MQPush(TQueue * queue, int value);
int MQPop(TQueue * queue);
int MQEmpty(TQueue * queue);