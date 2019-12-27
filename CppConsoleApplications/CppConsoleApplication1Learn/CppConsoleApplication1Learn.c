#include "CppConsoleApplication1Learn.h"
#include <windows.h>


typedef struct Fact
{
	int one;
	int two;
};



int main(int argc, const char* argv[])
{
	SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
	//HelloName();
	struct Fact f1;
	f1.one = 1;
	f1.two = 9;
	

	
	return 0;
}



