#include <iostream>
#include <conio.h>

#include "ConsoleApplication1.h"
#include "Task1.h"

using namespace std;
int main()
{
	Ru();
	
	//puts("Задача 1.");
	//TRoad road(60, 3);
	//const int N=3;
	//TCar * cars[N];
	//for (int i=0; i<N; i++)
	//{
	//	cars[i] = new TCar(&road, i+1, 2.0*(i+1));
	//}
	//do
	//{
	//	for (int i=0; i<N; i++)
	//		cars[i]->Move();
	//}
	//while (!_kbhit());
	
	TPen pen;
	pen.setColor("FFFF00");
	cout << "Цвет пера: " << pen.getColor() << endl;

	TNot n;
	n.setIn1(false);
	cout << "Результат: " << n.getRes() << endl;

	//TNot elNot;
	//TAnd elAnd;
	//int A, B;
	//cout << "A B !(A&B)" << endl;
	//cout << "----------" << endl;
	//for (A=0; A<=1; A++)
	//{
	//	elAnd.setIn1(A);
	//	for (B=0; B<=1; B++)
	//	{
	//		elAnd.setIn2(B);
	//		elNot.setIn1(elAnd.getRes());
	//		cout << " " << A << " " << B << "    " << elNot.getRes() << endl;
	//	}
	//}
	TNot elNot;
	TAnd elAnd;
	elAnd.Link(&elNot,1);
	for (int A=0; A<=1; A++)
	{
		elAnd.setIn1(A);
		for (int B=0; B<=1; B++)
		{
			elAnd.setIn2(B);
			cout << " " << A << " " << B << "    " << elNot.getRes() << endl;
		}
	}

	getchar();
}

