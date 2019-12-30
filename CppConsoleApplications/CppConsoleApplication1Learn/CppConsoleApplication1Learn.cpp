#include "CppConsoleApplication1Learn.h"
#include <windows.h>
#include <stdio.h>
#include <wchar.h>
#include <math.h>
#include <ctime>

#define AGELIMIT 21
#define MYNAME "Name"

int main(int argc, const char* argv[])
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	//float price = 0.0;
	//char nach[24];
	//int mounth, day, year;
	//printf_s("Введите стоимость кефира в магазине (формат $XX.XX):> ");
	//scanf_s(" $%f", &price);
	//printf_s("Любимая начинка?> ");
	//scanf_s(" %s", nach, _countof(nach));
	//printf_s("Введите седняшнее число (формат XX/XX/XX):> ");
	//scanf_s(" %d/%d/%d", &day, &mounth, &year);
	//printf_s("Сегодня %d.%d.%d нужно съесть пирог с начинкой \"%s\" и запить кефиром за $%f", day, mounth, year, nach, price);
	//int age = 30;
	//(age >= 21) ? (age = 21) : (age += 30);
	//age = (age >= 21) ? 21 : age + 30;
	//printf_s("Возраст %sслишком большой", (age < 90) ? "не " : "");
	//char msg[10];
	//printf_s("Введите 10 символов и нажмите Enter\n");
	//int len = 0;
	//for (int i=0; i < strlen(msg); i++)
	//{
	//	msg[i] = getchar();
	//	if (msg[i] == '\n')
	//	{
	//		len = i - 1;
	//		break;
	//	}
	//}
	//putchar('\n');
	//for (int i=0; i <= len; i++)
	//{
	//	putchar(msg[i]);
	//}
	//putchar('\n');
	//char fullStr[128];
	//char surnameName[64];
	//puts("Введите ваше имя фамилию:");
	//gets_s(surnameName);
	//char city[32];
	//puts("Город:");
	//gets_s(city);
	//puts("Ваши фамилия и имя:");
	//strcpy_s(fullStr, surnameName);
	//strcat_s(fullStr, " - годод ");
	//strcat_s(fullStr, city);
	//puts(fullStr);

	srand(time(NULL));
	int dice1 = (rand() % 5) + 1;
	printf_s("Значение игральной кости: %d", dice1);
	

	
	return 0;
}



