/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/29/2012
 * Time: 2:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DescendingOrder
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
			

			if (myInteger >  myInteger2)
	        {
	            if (myInteger > myInteger3)
	            {
	                if ( myInteger2 > myInteger3)
	                {
	                	Console.WriteLine("{0}"+"{1}"+"{2}", myInteger,  myInteger2, myInteger3);
	                }
	                else
	                {
	                    Console.WriteLine("{0}"+"{1}"+"{2}",myInteger, myInteger3,  myInteger2);
	                }
	            }
	            else
	            {
	                Console.WriteLine("{0}"+"{1}"+"{2}", myInteger3, myInteger,  myInteger2);
        		}
	        }
		        else if ( myInteger2 > myInteger3)
		        {
		            if (myInteger > myInteger3)
		            {
		                Console.WriteLine("{0}"+"{1}"+"{2}",  myInteger2, myInteger, myInteger3);
		            }
		            else
		            {
		                Console.WriteLine("{0}"+"{1}"+"{2}",  myInteger2, myInteger3, myInteger);
		            }
		        }
		        else
		        {
		            Console.WriteLine("{0}"+"{1}"+"{2}",myInteger3,  myInteger2, myInteger);
		        }
  
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}