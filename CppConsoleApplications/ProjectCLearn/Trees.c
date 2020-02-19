#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include "Trees.h"

int Priority(char op)
{
	switch (op)
	{
	case '+':
	case '-': return 1;
	case '*':
	case '/': return 2;
	}
	return 100;
}
int LastOperation(char s[])
{
	int minPriority = 50;
	int result = -1;
	for (int i = 0; i<strlen(s); i++)
		if (Priority(s[i])<=minPriority)
		{
			minPriority = Priority(s[i]);
			result=i;
		}
	return result;
}
Node * MakeTree(char s[])
{
	Node * Tree;
	char sLeft[80] = "";
	Tree = (Node *) calloc(1, sizeof(Node));
	int k = LastOperation(s);
	if (k == -1)
	{
		strcpy(Tree->data, s);
		Tree->left = NULL;
		Tree->right = NULL;
	}
	else
	{
		Tree->data[0]=s[k];
		Tree->data[1]='\0';
		strncpy(sLeft, s, k);
		Tree->left=MakeTree(sLeft);
		Tree->right=MakeTree(&s[k+1]);
	}
	return Tree;
}
int Calc(Node * tree)
{
	int res;
	if (tree->left == NULL)
		res = atoi(tree->data);
	else
	{
		int n1 = Calc(tree->left);
		int n2 = Calc(tree->right);
		switch (tree->data[0])
		{
		case '+': res = n1+n2;
			break;
		case '-': res = n1-n2;
			break;
		case '*': res = n1*n2;
			break;
		case '/': res = n1/n2;
			break;
		default: res = 99999;
		}
	}
	return res;
}
void PrePrint(Node * tree)
{
	if (tree->left==NULL)
		printf("%d ", atoi(tree->data));
	if (tree->data[0]=='+'||tree->data[0]=='-'||tree->data[0]=='*'||tree->data[0]=='/')
		printf("%c ", tree->data[0]);
	if (tree->left!=NULL)
		PrePrint(tree->left);
	if (tree->right!=NULL)
		PrePrint(tree->right);
}
void PostPrint(Node * tree)
{
	if (tree->left!=NULL)
		PostPrint(tree->left);
	if (tree->right!=NULL)
		PostPrint(tree->right);
	if (tree->left==NULL)
		printf("%d ", atoi(tree->data));
	if (tree->data[0]=='+'||tree->data[0]=='-'||tree->data[0]=='*'||tree->data[0]=='/')
		printf("%c ", tree->data[0]);
}
