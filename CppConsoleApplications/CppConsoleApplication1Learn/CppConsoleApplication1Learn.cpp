#include "CppConsoleApplication1Learn.h"
#include <iostream>
#include <windows.h>
#include <iomanip>
#include <string>
#include <sstream>

using namespace std;
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	float a = -12.25;
	cout << a;
	
	cin.get();
	return 0;
}

