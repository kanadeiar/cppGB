#include <stdio.h>
#include "Task1.h"

TRoad::TRoad()
{
	Length = 100;
	Width = 1;
}
TRoad::TRoad(float lenght0, int width0)
{
	if (lenght0>0)
		Length=lenght0;
	else Length=1;
	if (width0>0)
		Width=width0;
	else Width=1;
}

TCar::TCar()
{
	Road=NULL; P=0; V=0; X=0;
}
TCar::TCar(TRoad * road0, int p0, float v0)
{
	Road = road0;
	P=p0;
	V=v0;
	X=0;
}
void TCar::Move()
{
	X += V;
	if (X>Road->Length)
		X=0;
}


