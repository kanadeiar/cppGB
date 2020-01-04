#include "CppConsoleApplication1Learn.h"
#include <iostream>
#include <windows.h>
#include <iomanip>
#include <string>

void isContStr(string s1, string s2);

using namespace std;
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	
	
	
	
	string s = "Пример/строки";
	s.replace(s.find('/'), 1, " ");
	cout << "Строка: " << s << endl;	
	//string s = "Мишутов Сергей";
	//int nSpace = s.find(' ');
	//cout << "Номер пробела: " << nSpace << endl;
	//string family = s.substr(0, s.find(' '));
	//cout << "Фамилия: " << family << endl;
	//string name = s.substr(s.find(' ') + 1, s.size() - s.find(' ') - 1);
	//cout << "Имя: " << name << endl;
	//string Afamily = family.insert(0, name.substr(0,1)+ ". ");
	//cout << "Имя. фамилия: " << Afamily;
	cin.get();
	return 0;
}

void isContStr(string s1, string s2)
{
	if (s1 == s2)
		cout << s1 << " = " << s2 << endl;
	else if (s1 > s2)
		cout << s1 << " > " << s2 << endl;
	else
		cout << s1 << " < " << s2 << endl;
}



