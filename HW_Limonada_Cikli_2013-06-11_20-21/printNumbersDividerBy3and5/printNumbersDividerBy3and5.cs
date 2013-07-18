/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/15/2012
 * Time: 12:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace printNumbersDividerBy3and5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number.");
			int myNumber=int.Parse(Console.ReadLine());
			for (int i = 1; i <= myNumber; i++)
			{
				if(((i%3)==0)&&((i%7)==0))
				{
				Console.WriteLine("{0}",i);
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}