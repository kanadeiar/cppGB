#pragma once

int sum(int x, int y)
{
	int result = x + y;
	return result;
}

int isPrime(int number)
{
	int d = 0, i =1;
	while (i <= number)
	{
		if (number % i++ == 0)
			d++;
		else
			continue;
		if (d >= 3) return 0;
	}
	return (d == 2);
}
