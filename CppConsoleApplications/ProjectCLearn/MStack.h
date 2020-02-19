#pragma once
#include <stdlib.h>

typedef struct
{
	//char * data;
	char data[256];
	//int capacity;
	int size;
} MStack;
void MInit(MStack * stack)
{
	//stack->capacity = 10;
	//stack->data = (char *)calloc(10, sizeof(char));
	stack->size = 0;
};
//void MClear(MStack * stack)
//{
//	stack->capacity = 0;
//	free(stack->data);
//}
int MEmpty(MStack stack)
{
	return stack.size == 0;
}
void MPush(MStack * stack, char value)
{
	stack->size++;
	//if (stack->size > stack->capacity)
	//{
	//	stack->capacity += 10;
	//	stack->data = realloc(stack->data, sizeof(char) * stack->capacity);
	//}
	stack->data[stack->size-1] = value;
};
char MPop(MStack * stack)
{
	stack->size--;
	return stack->data[stack->size];
};
