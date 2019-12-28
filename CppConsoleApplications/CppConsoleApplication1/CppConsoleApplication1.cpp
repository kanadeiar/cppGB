

#include <stdio.h>
#include <stdlib.h>



int main(int argc, const char * argv[])
{
	printf_s("Введите имя:");
	char name[64];
	scanf_s(" %s", name, _countof(name));
	puts(name);
	return 0;
}

