/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/25/2012
 * Time: 2:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace euclideanAlgorithm
{
	class Program
	{
		public static void Main(string[] args)
		{
			 	int variableA;
                int variableB;
                int variableX;
                int variableResult;
 
                Console.Write("Please enter a value for \"A\"");
                string strA = Console.ReadLine();
 
                Console.Write("Please enter a value for \"B\"");
                string strB = Console.ReadLine();
 
                if (!int.TryParse(strA, out variableA))
                {
                        Console.WriteLine("Invalid number: {0}", strA);
                }
                else if (!int.TryParse(strB, out variableB))
                {
                        Console.WriteLine("Invalid number: {0}", strB);
                }
                else
                {
                        if (variableA == 0 && variableB > 0)
                        {
                                variableResult = variableB;
                        }
                        else if (variableB == 0 && variableA > 0)
                        {
                                variableResult = variableA;
                        }
                        else if (variableA > 0 && variableB > 0)
                        {
                                while (variableB > 0)
                                {
                                        variableX = variableB;
                                        variableB = variableA % variableB;
                                        variableA = variableX;
                                }
 
                                variableResult = variableA;
 
                                Console.WriteLine(variableResult);
                        }		
                }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		
                        
		}
    }
}
			
