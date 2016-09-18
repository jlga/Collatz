#include <iostream>
#include <ctime>

int main()
{
	int i;
	unsigned int start = clock();
	for (int k = 0; k < 10; k++)
	{
		for (int j = 1; j < 100000; j++)
		{
			i = j;
			while (i != 1)
			{
				if ((i & 1) != 0)
				{
					i = ((3 * i) + 1) >> 1;
				}
				else if ((i & 1) == 0)
				{
					i = i >> 1;
				}
				else
				{
					i = 1;
				}
			}
		}
	}
	unsigned int end = clock() - start;
	std::cout << "Time taken in millisecs: " << end;
	std::cin.ignore();
	return 0;
}