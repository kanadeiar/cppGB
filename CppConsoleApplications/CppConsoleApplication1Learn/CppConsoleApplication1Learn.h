#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <ctime>

//����� ����������
using namespace std;
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







inline void Task13()
{
	cout << "������� �����: ";
	int number;
	cin >> number;
	int n2 = number / 100 % 10;
	int n1 = number / 10 % 10;
	int n0 = number % 10;
	bool isPolyndrom = (n0 == n1) && (n1 == n2);
	cout << "�����: " << ((isPolyndrom) ? "��" : "���") << endl;
}


inline void Task11()
{
	while (true)
	{
		cout << "������� ������� �������� (-1 - �����):> ";
		int age;
		cin >> age;
		getchar();
		string endstr;
		if ( (age % 10 == 1) && (age / 10 % 10 != 1) )
			endstr += " ���";
		else if ( (age % 10 == 2 || age % 10 == 3 || age % 10 == 4) && (age / 10 % 10 != 1) )
			endstr += " ����";
		else
			endstr += " ���";
		cout << "��� " << age << endstr << endl;
	}
	cin.get();
}
inline void Task10()
{
	srand(time(NULL));
	int num = rand() % 899 + 100;
	cout << "�����: " << num << endl;
	cout << "�����: " << num / 100 << endl;
	cout << "�������:" << num / 10 % 10 << endl;
	cout << "�������:" << num % 10;	
}
inline void Task9()
{
	cout << "��� ������:> ";
	float passw;
	cin >> passw;
	passw = powf(passw, 2);
	int answer = int(passw * 10.) % 10;
	cout << answer;
}
