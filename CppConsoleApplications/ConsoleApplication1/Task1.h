#pragma once
#include <string>

using namespace std;
class TRoad
{
public:
	float Length{};
	int Width{};
	TRoad();
	TRoad(float lenght0, int width0 = 2);
};

class TCar
{
public:
	float X, V;
	int P;
	TRoad * Road;
	void Move();
	TCar();
	TCar( TRoad * road0, int p0, float v0);
};

class TPen
{
private:
	int FColor;
	int val;
public:
	string getColor();
	void setColor(string newColor);
	int getVal() {return val;}
};

class TLogElement //����������� �����(=0)
{
private:
	bool FIn1, FIn2;
	//����� � ������ �������
	TLogElement * FNextEl; //������ �� ��������� ���������� �������
	int FNextIn; //����� ����� ����� ���������� ��������, � �������� ��������� ����� ������� ��������
protected:
	bool FRes;
	virtual void calc()=0; //����������� �����������(=0) �����
	bool getIn2() {return FIn2;} //����������
	void setIn2(bool newIn2); //����������
public:
	bool getIn1() {return FIn1;}
	void setIn1(bool newIn1);
	bool getRes() {return FRes;}
	//����� � ������ �������
	void Link(TLogElement *nextElement, int nextIn=1);
};
class TLog2In: public TLogElement
{
public:
	TLogElement::setIn2; //�������� �����������
	TLogElement::getIn2; //�������� �����������
};

class TNot: public TLogElement
{
protected:
	void calc();
};
class TAnd: public TLog2In
{
protected:
	void calc(); //���������������
};
class TOr: public TLog2In
{
protected:
	void calc(); //���������������
};
