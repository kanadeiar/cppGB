#include <stdio.h>
#include <windows.h>
#include <time.h>
#include <ctype.h>
#include <stdlib.h>
#include "Header.h"

#include "Trees.h"


Node * tree;

int main(int argc, char * args[])
{
	Ru();
	char s[80] = "40-2*3-4*5";
	tree = MakeTree(s);
	const int rs = Calc(tree);
	printf("Результат: %d\n", rs);

	puts("Печать:");
	PrePrint(tree);
	printf("\n");
	puts("Печать:");
	PostPrint(tree);
	printf("\n");
	
	getchar();
}

