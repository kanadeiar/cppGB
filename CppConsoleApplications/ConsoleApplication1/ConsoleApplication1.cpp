#include <iostream>
#include <conio.h>

#include "ConsoleApplication1.h"
#include "Task1.h"

using namespace std;
int main()
{
	Ru();
	
	puts("Задача 1.");
	TRoad road(60, 3);
	const int N=3;
	TCar * cars[N];
	for (int i=0; i<N; i++)
	{
		cars[i] = new TCar(&road, i+1, 2.0*(i+1));
	}
	do
	{
		for (int i=0; i<N; i++)
			cars[i]->Move();
	}
	while (!_kbhit());
	
	TPen pen;
	pen.setColor("FFFF00");
	cout << "Цвет пера: " << pen.getColor();

	getchar();
}

