#include <iostream>

#include "ConsoleApplication1.h"
#include "Task1.h"

using namespace std;
int main()
{
	Ru();
	
	puts("Задача 1.");
	TRoad road1;
	printf("Data road: %d %.1f\n", road1.Width, road1.Length);
	TCar car1;
	printf("Data car: %.1f %.1f %d\n", car1.X, car1.V, car1.P);
	
	
	
	
	getchar();
}

