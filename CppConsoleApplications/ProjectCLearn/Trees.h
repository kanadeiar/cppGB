#pragma once


typedef struct
{
	char data[20];
	struct Node * left;
	struct Node * right;
} Node;
int Priority(char op);
int LastOperation(char s[]);
Node * MakeTree(char s[]);
int Calc(Node * tree);
void PrePrint(Node * tree);
void PostPrint(Node * tree);

