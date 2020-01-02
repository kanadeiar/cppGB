#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <ctime>

//вывод привествия
using namespace std;
inline void HelloName()
{
	puts("Привет, Мир!");
	puts("Введите свое имя:");
	char name[256];
	gets_s(name, _countof(name));
	char welcome[256] = "Привет, ";
	strcat_s(welcome, _countof(welcome), name);
	strcat_s(welcome, _countof(welcome), "!");
	puts(welcome);
}







inline void Task13()
{
	cout << "Введите число: ";
	int number;
	cin >> number;
	int n2 = number / 100 % 10;
	int n1 = number / 10 % 10;
	int n0 = number % 10;
	bool isPolyndrom = (n0 == n1) && (n1 == n2);
	cout << "Ответ: " << ((isPolyndrom) ? "да" : "нет") << endl;
}


inline void Task11()
{
	while (true)
	{
		cout << "Введите возраст человека (-1 - выход):> ";
		int age;
		cin >> age;
		getchar();
		string endstr;
		if ( (age % 10 == 1) && (age / 10 % 10 != 1) )
			endstr += " год";
		else if ( (age % 10 == 2 || age % 10 == 3 || age % 10 == 4) && (age / 10 % 10 != 1) )
			endstr += " года";
		else
			endstr += " лет";
		cout << "Вам " << age << endstr << endl;
	}
	cin.get();
}
inline void Task10()
{
	srand(time(NULL));
	int num = rand() % 899 + 100;
	cout << "Число: " << num << endl;
	cout << "сотни: " << num / 100 << endl;
	cout << "десятки:" << num / 10 % 10 << endl;
	cout << "еденицы:" << num % 10;	
}
inline void Task9()
{
	cout << "Ваш пароль:> ";
	float passw;
	cin >> passw;
	passw = powf(passw, 2);
	int answer = int(passw * 10.) % 10;
	cout << answer;
}
