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
public:
	string getColor();
	void setColor(string newColor);
};
