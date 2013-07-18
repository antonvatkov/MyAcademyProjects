/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 12/2/2012
 * Time: 6:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FiveDigitsLarge
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter an integer.");
			int variableA=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Please enter an integer.");
			int variableB=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Please enter an integer.");
			int variableC=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Please enter an integer.");
			int variableD=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Please enter an integer.");
			int variableE=int.Parse(Console.ReadLine());
			
			int maxAB=Math.Max(variableA,variableB);
			int maxCD=Math.Max(variableC,variableD);
			int maxABandCD=Math.Max(maxAB,maxCD);
			if (maxABandCD<variableE) 
			{
				Console.WriteLine(variableE);
			}
			else
			{
				Console.WriteLine(maxABandCD);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}