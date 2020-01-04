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
	int a = 5;
	int b = 3;
	int c;
	__asm
	{
		mov eax, dword ptr[a];
		mov ebx, dword ptr[b];
		cmp eax, ebx;
		jle if1_not
		mov dword ptr[c], eax;
		jmp if1_end
		if1_not:
		mov dword ptr [c], ebx;
		if1_end:
	}
	cout << c;

	

	
	//ostringstream sbuf; //вспомогательный выходной буферный поток символов
	//int num = 123;
	//sbuf << num;
	//string sNum = sbuf.str(); // 123
	//sbuf.str(""); //очистка
	//float numF = 123.123456;
	//sbuf << fixed << setprecision(2) << setw(8) << numF;
	//string sFlt = sbuf.str(); //123.123
	//sbuf.str(""); //очистка
	//double numD = 0.0000232342;
	//sbuf << scientific << setprecision(6) << setw(16) << numD;
	//string sScientific = sbuf.str(); //2.323420e-05 - научный формат
	//cout << "Числа: " << sNum << ' ' << sFlt << ' ' << sScientific << endl;

	cin.get();
	return 0;
}





