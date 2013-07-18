/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/25/2012
 * Time: 4:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HomeWorkLoops
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a value for \"N\"");
			int valriableN=int.Parse(Console.ReadLine());
			for (int i = 1; i <= valriableN; i++)  
			{
				Console.WriteLine(i);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}