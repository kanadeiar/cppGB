#include "MQueue.h"

void MQInit(TQueue * queue)
{
	queue->size = 0;
	queue->head = 0;
	queue->tail = -1;
}
void MQPush(TQueue * queue, int value)
{
	queue->size++;
	if (queue->size > SIZE_Q)
	{
		puts("Переполнение очереди!");
		return;
	}
	queue->tail++;
	if (queue->tail >= SIZE_Q)
		queue->tail = 0;
	queue->data[queue->tail] = value;
}
int MQPop(TQueue * queue)
{
	if (queue->size == 0)
	{
		puts("Стек пуст!");
		return -1;
	}
	queue->size--;
	int tmp = queue->data[queue->head];
	queue->head++;
	if (queue->head >= SIZE_Q)
		queue->head = 0;
	return tmp;
}
int MQEmpty(TQueue * queue)
{
	return queue->size == 0;
}