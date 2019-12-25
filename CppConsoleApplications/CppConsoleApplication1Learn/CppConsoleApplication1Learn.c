

#include <locale.h>
#include <stdio.h>
#include <math.h>

int getNum();
void do_work();
int pow(int base, int sign);


int main()
{
	setlocale(LC_ALL, "russian");
	do_work();
	int rez = pow(2,10);
	printf_s("\nРезультат: %d", rez);
	
	getchar();
}

void do_work()
{
	int num = 71;

	printf("\n");
	int d = 0, i = 1;
	while (i <= num)
	{
		if (num % i++ == 0)
			d++;
		else
			continue;
		if (d == 3) break;
	}
	printf_s("Введенное число %d %s является простым числом", num, (d==2) ? "" : "не ");
}

int pow(int base, int sign)
{
	int result = 1;
	for (int i = 0; i<sign; i++)
	{
		result *= base;
	}
	return result;
}

