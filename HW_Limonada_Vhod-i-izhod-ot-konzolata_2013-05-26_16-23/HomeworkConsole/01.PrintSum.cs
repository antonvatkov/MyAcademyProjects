/*
*Write a program that reads 3 integer numbers from the console and prints their sum.
*/
using System;
class PrintSum
{
	public static void Main()
	{	
		Console.WriteLine("Please enter an integer for first variable");
		int dolars= TryToParse(Console.ReadLine());
		if (dolars==0) 
		{
			Main();//if wrong input -->returns to beginning
		}
		Console.WriteLine("Please enter an integer for second variable");
		int euros = TryToParse(Console.ReadLine());
		if (euros==0) 
		{
			Main();//if wrong input -->returns to beginning
		}
		Console.WriteLine("Please enter an integer for thirth variable");
		int pesos = TryToParse(Console.ReadLine());
		if (pesos==0) 
		{
			Main();//if wrong input -->returns to beginning
		}
		SumMoney(dolars,euros,pesos);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
	//Sum method
	public static void SumMoney (int dolars,int euros,int pesos)
	{
		long Result=dolars+euros+pesos;
		Console.WriteLine(Result);
	}
	//Check input data method
	private static int TryToParse(string value)
   {
      int number;
      bool result = Int32.TryParse(value, out number);
      if (result)
      {
      	number=int.Parse(value);
  		return number;
      }
      else
      { 
      	Console.WriteLine("Please enter a correct data:Input error: {0}", value);
        return 0;
      }
	}
}
