/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/29/2012
 * Time: 5:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace QuadraticExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a value for \"A\".");
			string myIntegerString = Console.ReadLine();
			int myIntegerA= int.Parse(myIntegerString );
			
			Console.WriteLine("Please enter a value for \"B\".");
			string myIntegerString2 = Console.ReadLine();
			int myIntegerB= int.Parse(myIntegerString2 );
			
			Console.WriteLine("Please enter a value for \"C\".");
			string myIntegerString3 = Console.ReadLine();
			int myIntegerC= int.Parse(myIntegerString3 );
			
			string myResult=(myIntegerA+"X^2+"+myIntegerB+"X+"+myIntegerC+"= 0");
			float D=((float)myIntegerB*(float)myIntegerB)-4*((float)myIntegerA*(float)myIntegerC);
			Console.WriteLine(myResult);
			if(D>0)
			{
				float x1= ((-myIntegerB) + Math.Abs(D))/(2*myIntegerC);
				float x2= ((-myIntegerB) - Math.Abs(D))/(2*myIntegerC);
				Console.WriteLine("X1={0}"+"X2={1}",x1,x2);
			}
			if (D==0) 
			{
				float x1;
				x1=(-myIntegerB)/(2*myIntegerA);
				Console.WriteLine("{0}",x1);
			}
			if (D<0)
			{
				Console.WriteLine("no real roots");
			}
			
			Console.ReadKey(true);
		
		}
	}
}