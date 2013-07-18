/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/23/2012
 * Time: 10:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace fibonacciSum
{
	class fibonacciSum
	{
		public static void Main(string[] args)
		{
			int myNumber;
               	int memberFirst = 0;
                int memberSecond = 1;
                int nextMember = 0;
                int mySum = 1;
 
                Console.Write("Please enter value for \"N\"");
                string strMyNumber = Console.ReadLine();
 
                if (!int.TryParse(strMyNumber, out myNumber))
                {
                        Console.WriteLine("Invalid number: {0}", strMyNumber);
                }
                else
                {
                	for (int i =1 ; i < (myNumber-1); i++)
                    {
                                mySum = mySum + (memberFirst + memberSecond);
            					nextMember = memberFirst;
            					memberFirst = memberSecond;
            					memberSecond = memberFirst + nextMember;
                	}
                }	
                Console.WriteLine("The sum of the element to N is {0}.", mySum);
		            Console.Write("Press any key to continue . . . ");
					Console.ReadKey(true);
		}
	}
}