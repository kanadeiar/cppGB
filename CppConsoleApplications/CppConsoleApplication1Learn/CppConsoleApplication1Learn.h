#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

inline void HelloName()
{
	puts("������, ���!");
	puts("������� ���� ���:");
	char name[256];
	gets_s(name, _countof(name));
	char welcome[256] = "������, ";
	strcat_s(welcome, _countof(welcome), name);
	strcat_s(welcome, _countof(welcome), "!");
	puts(welcome);
}


