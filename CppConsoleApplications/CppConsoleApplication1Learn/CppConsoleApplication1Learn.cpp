#include "CppConsoleApplication1Learn.h"
#include <iostream>
#include <windows.h>
#include <iomanip>
#include <string>
#include <sstream>
#include <fstream>



using namespace std;
int main()
{
	Ru();
	string s;

	ifstream fin;
	fin.open("data.txt");
	if (fin)
	{
		int i = 1;
		while (getline(fin, s))
		{
			int p = s.rfind(' ');
			string st = s.substr(p + 1);
			int balls = stoi(st);
			if (balls >= 80)
			{
				st = s.substr(0, p);
				cout << i++ << ") " << st << endl;
			}
			
		}
	}
	else
	{
		cout << "Не открылся файл.";
		cin.get();
		exit(1);
	}

	
	fin.close();

	cin.get();
	////////////////////////////////
	return 0;
}

