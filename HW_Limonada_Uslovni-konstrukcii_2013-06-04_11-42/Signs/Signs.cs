/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/29/2012
 * Time: 10:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Signs
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
			
			Console.WriteLine("Please enter a integer.");
			string myIntegerString3 = Console.ReadLine();
			int myInteger3= int.Parse(myIntegerString3 );
			
			int myCounter=0;
			if ((myInteger==0) || (myInteger2==0) || (myInteger3==0))
			{
				Console.WriteLine("The product is zero.");
			}
			else
	        {
		        if (myInteger < 0)
		        {
		            myCounter++;
		        }
		        if (myInteger2 < 0)
		        {
		            myCounter++;
		        }
		        if (myInteger3 < 0)
		        {
		            myCounter++;
		        }
		        if (myCounter == 1 || myCounter == 3)
		        {
		            Console.WriteLine("The  product is Negative number");
		        }
		        else
		        {
		            Console.WriteLine("The  product is Positive number");
		        }
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}