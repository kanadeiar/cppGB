#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <time.h>
#include <string>

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













inline void Task12_9()
{
	puts("9 �����");
	string s = "12+134+45+17";
	int one;
	int two;
	int three;
	int four;
	int n1 = s.find('+');
	if (n1 == s.npos)
		exit(1);
	s.replace(n1, 1, "_");
	int n2 = s.find('+');
	if (n2 == s.npos)
		exit(1);
	s.replace(n2, 1, "_");
	int n3 = s.find('+');
	if (n3 == s.npos)
		exit(1);
	s.replace(n3, 1, "_");
	one = stoi(s.substr(0, n1));
	two = stoi(s.substr(n1+1, n2- n1 - 1));
	three = stoi(s.substr(n2+1, n3 - n2 - 1));
	four = stoi(s.substr(n3+1, s.size() - n3 - 1));
	int sum = one + two + three + four;
	cout << "�����: " << sum << endl;	
	cin.get();
}
inline void Task22()
{
	int arr_size = 20;
	int * arr = static_cast<int*>(malloc(arr_size * sizeof(int)));
	srand(time(NULL));
	for (int i=0; i<arr_size; i++)
		*(arr + i) = rand() % 100 + 50;
	int * pMin = nullptr;
	for (int i=0; i<arr_size; i++)
		if (*(arr + i) % 2 == 0)
			if (pMin == nullptr || *(arr + i) < *pMin)
				pMin = arr + i;
	printf_s("����������� �������: %d, ��� �����: %d\n", *pMin, pMin - arr);
	puts("���� ������:");
	for (int i=0; i<arr_size; i++)
		printf_s("%d ", *(arr + i));
	free(arr);
	cin.get();
}
inline void Task20()
{
	int arr[10];
	cout << "������� �������� �������:" << endl;
	for (int i = 0; i < _countof(arr); i++)
	{
		cout << "arr[" << i << "]=";
		cin >> arr[i];
		getchar();
	}
	int summ = 0;
	for (int i = 0; i < _countof(arr); i++)
		summ += arr[i];
	cout << "������� ��������: " << float(summ) / _countof(arr);
	cin.get();
}
inline void Task18()
{
	cout << "����� ����������:" << endl;
	for (int i = 1; i < INT_MAX; i++)
	{
		int count = 0;
		int num = i;
		while (num != 0)
		{
			count++;
			num /= 10;
		}
		num = i;
		int sum = 0;
		while (num != 0)
		{
			sum += powf(round(num % 10), count);
			num /= 10;
		}
		if (sum == i)
			cout << i << endl;
	}
	cout << "�����";
	
	cin.get();
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
