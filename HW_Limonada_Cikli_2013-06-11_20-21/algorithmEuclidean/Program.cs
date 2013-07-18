/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/25/2012
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace algorithmEuclidean
{
	class Program
	{
		public static void Main(string[] args)
		{

			int variableN ;
				int variableM ;
			Console.WriteLine("Please enter value for \"A\" ");
			int variableA = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter value for \"B\" ");
			int variableB = int.Parse(Console.ReadLine());
			int loopLeinght=Math.Max(variableA,variableB);
			for ( int k = 1; k < loopLeinght; k++) 
			{
				variableA % k =variableN;
				variableB % k =variableM;
					if (variableA-variableB==(variableN-variableM)*k)
					{
						Console.WriteLine("Greatest common divisor is {0}.",k);
					{
			}
 
                                
            // For if k, m, and n are integers, and k is a common factor of two integers A and B, then A = nk and B = mk implies A − B = (n − m)k, 
			// therefore k is also a common factor of the difference. That k may also represent the greatest common divisor is proven below.
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
	}}