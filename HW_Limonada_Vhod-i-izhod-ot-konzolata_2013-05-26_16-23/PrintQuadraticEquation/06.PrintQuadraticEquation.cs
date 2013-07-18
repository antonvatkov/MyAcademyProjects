/*
*Write a program that reads the coefficients a, b and c 
*of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
*/
using System;
class PrintQuadraticEquation
{
	public static void Main()
	{
		Console.WriteLine("Please enter coefitients A");

		double ParametreA=double.Parse(Console.ReadLine());
	 	Console.WriteLine("Please enter coefitients B");
		double ParametreB=double.Parse(Console.ReadLine());
	 	Console.WriteLine("Please enter coefitients C");
		double ParametreC=double.Parse(Console.ReadLine());
	 	if (ParametreA==0) 
	 	{
	 		double linearRoot= -(ParametreC/ParametreB);
	 		Console.WriteLine("Linear equation and the root is:{0} ",linearRoot);
	 	}
	 	double D = ((Math.Pow(ParametreB,2))-(4*(ParametreA*ParametreC)));
 		if (D<0)
		{
			Console.WriteLine("There are no real roots");
		}
		if (D==0) 
		{
			double doubleRoot = -(ParametreB / (2 * ParametreA));
            Console.WriteLine("There is double root: +- {0}", doubleRoot);
		}
		if (D>0) 
		{
			double rootOne = (-ParametreB + Math.Sqrt(D)) / (2 * ParametreA);
			double rootSecond = (-ParametreB - Math.Sqrt(D)) / (2 * ParametreA);
            Console.WriteLine("There are two real roots: {0} and {1}", rootOne,rootSecond);
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
