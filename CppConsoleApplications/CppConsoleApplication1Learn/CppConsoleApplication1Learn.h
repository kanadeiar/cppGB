#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>
#include <time.h>
#include <string>
#include <iomanip>
#include <windows.h>

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

inline void Ru()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
}



























inline void Task10_3()
{
	cout << "������� �����:" << endl;
	int num;
	cin >> num;
	getchar();
	char snum[256] = "";
	while (num != 0)
	{
		char stmp[256];
		strcpy_s(stmp, _countof(stmp), snum);
		sprintf_s(snum, _countof(snum), "%d", num % 8);
		strcat_s(snum, stmp);
		//cout << num % 8;
		num /= 8;
	}
	cout << snum << endl;	
	cin.get();
}
inline bool isSimple( int n )
{
	int k = 2;
	while ( k*k <= n && n%k != 0 )
		k++;
	return ( k*k > n );
}
bool isArmstrong(int num)
{
	int count = 0;
	int numtmp = num;
	while (numtmp != 0)
	{
		count++;
		numtmp /= 10;
	}
	int summ = 0;
	numtmp = num;
	while (numtmp != 0)
	{
		summ += powf(numtmp % 10, count);
		numtmp /= 10;
	}
	if (summ == num)
		return true;
	return false;
}
inline void Task10_2()
{
	printf_s("����� ����������:\n");

	for (int i = 100; i < 10000; i++)
		if (isArmstrong(i))
			printf_s("%d ", i);

	getchar();
}
void getStrAges(int number, char * strs)
{
	strcpy_s(strs, 33, "");

	switch (number / 100 % 10)
	{
	case 1: strcat_s(strs, 33, " ���");
		break;
	case 2: strcat_s(strs, 33, " ������");
		break;
	case 3: strcat_s(strs, 33, " ������");
		break;
	case 4: strcat_s(strs, 33, " ���������");
		break;
	case 5: strcat_s(strs, 33, " �������");
		break;
	case 6: strcat_s(strs, 33, " ��������");
		break;
	case 7: strcat_s(strs, 33, " �������");
		break;
	case 8: strcat_s(strs, 33, " ���������");
		break;
	case 9: strcat_s(strs, 33, " ���������");
		break;
	}
	switch (number / 10 % 10)
	{
	case 1:
		switch (number % 10)
		{
		case 1: strcat_s(strs, 33, " ����������");
			break;
		case 2: strcat_s(strs, 33, " ����������");
			break;
		case 3: strcat_s(strs, 33, " ����������");
			break;
		case 4: strcat_s(strs, 33, " ������������");
			break;
		case 5: strcat_s(strs, 33, " ����������");
			break;
		case 6: strcat_s(strs, 33, " �����������");
			break;
		case 7: strcat_s(strs, 33, " ����������");
			break;
		case 8: strcat_s(strs, 33, " ������������");
			break;
		case 9: strcat_s(strs, 33, " ������������");
			break;
		case 0: strcat_s(strs, 33, " ������");
			break;
		}
		break;
	case 2: strcat_s(strs, 33, " ��������");
		break;
	case 3: strcat_s(strs, 33, " ��������");
		break;
	case 4: strcat_s(strs, 33, " �����");
		break;
	case 5: strcat_s(strs, 33, " ���������");
		break;
	case 6: strcat_s(strs, 33, " ���������");
		break;
	case 7: strcat_s(strs, 33, " ���������");
		break;
	case 8: strcat_s(strs, 33, " �����������");
		break;
	case 9: strcat_s(strs, 33, " ���������");
		break;
	}
	if (number / 10 % 10 != 1)
		switch (number % 10)
		{
		case 1: strcat_s(strs, 33, " ����");
			break;
		case 2: strcat_s(strs, 33, " ���");
			break;
		case 3: strcat_s(strs, 33, " ���");
			break;
		case 4: strcat_s(strs, 33, " ������");
			break;
		case 5: strcat_s(strs, 33, " ����");
			break;
		case 6: strcat_s(strs, 33, " �����");
			break;
		case 7: strcat_s(strs, 33, " ����");
			break;
		case 8: strcat_s(strs, 33, " ������");
			break;
		case 9: strcat_s(strs, 33, " ������");
			break;
		}
	if (number == 0)
		strcat_s(strs, 33, " ����");
}

void Task10_1()
{
	while (true)
	{
		printf_s("������� ����� (-1 - �����):");
		int number;
		scanf_s(" %d", &number);
		getchar();
		if (number == -1)
			break;
		char strs[33];
		getStrAges(number, strs);
		printf_s("%s\n", strs);
	}
}

bool isOneByte(int num)
{
	return num <= 255;
}
inline void Task22_9()
{
	cout << "������� �����: ";
	int num;
	cin >> num;

	if (isOneByte(num))
		cout << "����������!";
	else
		cout << "�� ����������!";

	cin.get();
}

string toDSys(int num)
{
	string itemp = to_string((num % 2));
	num /= 2;
	if (num == 0)
		return itemp;
	return toDSys(num) + itemp;
}

string getNum16(int num)
{
	int itemp = num % 16;
	char ctemp;
	if (itemp == 0)
		ctemp = '0';
	else if (itemp == 1)
		ctemp = '1';
	else if (itemp == 2)
		ctemp = '2';
	else if (itemp == 3)
		ctemp = '3';
	else if (itemp == 4)
		ctemp = '4';
	else if (itemp == 5)
		ctemp = '5';
	else if (itemp == 6)
		ctemp = '6';
	else if (itemp == 7)
		ctemp = '7';
	else if (itemp == 8)
		ctemp = '8';
	else if (itemp == 9)
		ctemp = '9';
	else if (itemp == 10)
		ctemp = 'A';
	else if (itemp == 11)
		ctemp = 'B';
	else if (itemp == 12)
		ctemp = 'C';
	else if (itemp == 13)
		ctemp = 'D';
	else if (itemp == 14)
		ctemp = 'E';
	else if (itemp == 15)
		ctemp = 'F';
	num = num / 16;	
	if (num == 0)
	{
		return string(1, ctemp);
	}	
	return getNum16(num) + ctemp;
}
inline void Task20_9()
{
	string num16 = getNum16(123);
	cout << "�����: " << num16 << endl;
	cin.get();
}
inline void Task18_9()
{
	const int N = 4, M = 4;
	int mtx[N][M];
	int * mtx_end = mtx[N];
	srand(time(NULL));
	//////////////////////////////
	for (int *pI = &mtx[0][0]; pI < mtx_end; pI++)
		*pI = rand() % 99;
	puts("�������:");
	for (int *pI = &mtx[0][0]; pI < mtx_end; pI++)
	{
		cout << *pI << ' ';
		if ( (pI - &mtx[0][0] + 1) % N == 0 )
			cout << endl;
	}
	puts("\n������������ ������� ���� �������:");
	int * pMax = &mtx[0][0];
	for (int *pI = &mtx[0][0]; pI < mtx_end; pI++)
		if (*pI > *pMax)
			pMax = pI;
	int iMax = (pMax - &mtx[0][0]) / N;
	int jMax = (pMax - &mtx[0][0]) % N;
	cout << "mtx[" << iMax << "," << jMax << "]=" << *pMax;

	cin.get();
}
inline void Task15_9()
{
	int arr[10];
	int * arr_end = arr + 10;
	srand(time(NULL));
	for (int * pI = arr; pI < arr_end; pI++)
		*pI = rand() % 20;
	cout << "������:" << endl;
	for (int * pI = arr; pI < arr_end; pI++)
		cout << *pI << ' ';
	cout << endl;
	//////////////////////////////////////
	for (int * pI = arr_end - 1; pI >= arr; pI--)
	{
		int * pMax = pI;
		for (int * pJ = arr; pJ < pI - 1; pJ++)
		{
			if (*pJ > *pMax)
				pMax = pJ;
		}
		if (pMax != pI)
		{
			int temp = *pI;
			*pI = *pMax;
			*pMax = temp;
		}
	}
	//////////////////////////////////////
	cout << "��������������� ������:" << endl;
	for (int * pI = arr; pI < arr_end; pI++)
		cout << *pI << ' ';
	cout << endl;
	cin.get();
}
inline void Array()
{
	srand(time(NULL));
	/////////////////////////////
	int * arr = new int [30];
	int * arr_last = &arr[29];
	for (int * pI = arr; pI <= arr_last; pI++)
		*pI = rand() % 99;
	/////////////////////////////
	for (int * pI = arr; pI <= arr_last - 1; pI++)
	{
		int * pMin = pI;
		for (int * pJ = pI + 1; pJ <= arr_last; pJ++)
		{
			if (*pJ < *pMin)
				pMin = pJ;
		}
		if (pMin != pI)
		{
			int temp = *pI;
			*pI = *pMin;
			*pMin = temp;
		}
	}
	/////////////////////////////
	cout << "������:" << endl;
	for (int * pI = arr; pI <= arr_last; pI++)
		cout << *pI << ' ';
	delete [] arr;
//	ostringstream sbuf; //��������������� �������� �������� ����� ��������
//	int num = 123;
//	sbuf << num;
//	string sNum = sbuf.str(); // 123
//	sbuf.str(""); //�������
//	float numF = 123.123456;
//	sbuf << fixed << setprecision(2) << setw(8) << numF;
//	string sFlt = sbuf.str(); //123.123
//	sbuf.str(""); //�������
//	double numD = 0.0000232342;
//	sbuf << scientific << setprecision(6) << setw(16) << numD;
//	string sScientific = sbuf.str(); //2.323420e-05 - ������� ������
//	cout << "�����: " << sNum << ' ' << sFlt << ' ' << sScientific << endl;
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
