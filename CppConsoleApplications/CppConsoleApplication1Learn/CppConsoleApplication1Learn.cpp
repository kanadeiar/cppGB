#include "CppConsoleApplication1Learn.h"
#include <iostream>
#include <windows.h>
#include <iomanip>
#include <string>
#include <sstream>
#include <fstream>
#include <vector>


using namespace std;
int main()
{
	Ru();
	//int * arr = new int[10];
	//delete [] arr;

	vector<int> arr;
	cout << "Size: " << arr.size() << endl;
	for (int i = 0; i<10; i++)
		arr.push_back(i+1);
	for (int i = 0; i<10; i++)
		cout << arr[i] << " ";
	cout << endl << "Size: " << arr.size() << endl;


	
	////////////////////////////////
	cin.get();
	return 0;
}

