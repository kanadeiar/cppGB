#include <stdio.h>
#include <sstream>
#include <iomanip>
#include "Task1.h"

using namespace std;
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

string TPen::getColor() {
	stringstream s;
	s << setfill('0') << setw(6) << hex << FColor;
	return s.str();
}
void TPen::setColor(string newColor)
{
	stringstream s;
	if (newColor.length()!=6)
		FColor=0;
	else
	{
		s << newColor;
		s >> hex >> FColor;
	}
}

//TLogElement::TLogElement()
//{
//	FNextEl=NULL;
//}
void TLogElement::setIn1(bool newIn1)
{
	FIn1=newIn1;
	calc();
	if (FNextEl) //если следующий элемент задан, то изменение его входов
		switch (FNextIn)
		{
		case 1: FNextEl->setIn1(getRes()); 
			break;
		case 2: FNextEl->setIn2(getRes()); 
			break;
		}
}
//связь с другим классом
void TLogElement::Link(TLogElement* nextElement, int nextIn)
{
	FNextEl=nextElement;
	FNextIn=nextIn;
}
void TLogElement::setIn2(bool newIn2)
{
	FIn2=newIn2;
	calc();
}
void TNot::calc()
{
	FRes=!getIn1();
}
void TAnd::calc()
{
	FRes=getIn1()&&getIn2();
}
void TOr::calc()
{
	FRes=getIn1()||getIn2();
}
