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
	////////////////////////////////

	const int n = 10;
	int arr[n] = {};
	int i = 10;
	for (auto &element : arr)
		element = i++;
	int temp;
	for (int i = 0; i < n/2; i++)
	{
		temp = arr[i];
		arr[i] = arr[n - 1 - i];
		arr[n - 1 - i] = temp;
	}
	

	
	cin.get();
	////////////////////////////////
	return 0;
}

