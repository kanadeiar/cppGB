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
//Node * tree;
//	char s[80] = "40-2*3-4*5";
//	tree = MakeTree(s);
//	const int rs = Calc(tree);
//	printf("���������: %d\n", rs);
//
//	puts("������:");
//	PrePrint(tree);
//	printf("\n");
//	puts("������:");
//	PostPrint(tree);
//	printf("\n");