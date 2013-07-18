/*
*Write a program that gets a number n and after that gets more 
* n numbers and calculates and prints their sum.
*/
using System;
class SumOfNNumbers
{
	public static void Main()
	{
		Console.WriteLine("Please enter a number");
		int sum=int.Parse(Console.ReadLine());
		Console.WriteLine("The sum is {0}",sum);
		GetNextNumber(sum);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
		private static void GetNextNumber(int sum)				//Sum Method
	{
		Console.WriteLine("Please enter the next number");
		int nextNumber=int.Parse(Console.ReadLine());
		int result=sum+nextNumber;
		Console.WriteLine("The sum is:{0}",result);
		GetNextNumber(result); 									//recursion
	}
}
