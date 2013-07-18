/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/25/2012
 * Time: 8:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace myHomeWorkStatement
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Please enter a integer.");
			string myIntegerString = Console.ReadLine();
			int myInteger= int.Parse(myIntegerString );
			
			Console.WriteLine("Please enter a integer.");
			string myIntegerString2 = Console.ReadLine();
			int myInteger2= int.Parse(myIntegerString2 );
			
			if (myInteger>myInteger2) 
			{
				int myTemp=myInteger;
				myInteger=myInteger2;
				myInteger2=myTemp;
			}
			Console.Write("{0}" + "{1}",myInteger,myInteger2);		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}