/*
*Write a program that gets two numbers from the console and prints the greater of them. 
*Don’t use if statements.
*/
using System;
class PrintGreaterNumber
{
	public static void Main()
	{
		Console.WriteLine("Please enter the first number:");
        short firstNumber = short.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        short secondNumber = short.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is:");
        Console.WriteLine(Math.Max(firstNumber,secondNumber));
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
