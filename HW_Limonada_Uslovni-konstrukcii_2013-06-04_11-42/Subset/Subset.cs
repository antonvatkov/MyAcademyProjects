/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 12/2/2012
 * Time: 8:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Subset
{
	class Subset
	{
		public static void Main(string[] args)
		{
			int[] numbers = new int[5];
        int counter = 0;
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());                        
        }
        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }
            if (sum == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter + " Subset Sums = 0");    
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}