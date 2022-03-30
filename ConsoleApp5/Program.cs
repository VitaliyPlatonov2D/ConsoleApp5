using System;
using System.Collections.Generic;
var numsList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
foreach (var salmon in numsList)
{
	Console.Write(salmon + " ");

}
Console.WriteLine("   ");

int n = 0;

	int len = numsList.Count / 2;

	for (int i = 0; i < len; i++)
	{
		int t = numsList[i];

		numsList[i] = numsList[len + i];

		numsList[len + i] = t;
	n++;
	
	}
	
	Console.WriteLine(String.Join(" ", numsList));
Console.WriteLine("Кол-во выполненных перестановок: " + n);





