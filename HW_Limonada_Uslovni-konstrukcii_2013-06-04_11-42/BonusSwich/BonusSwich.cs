/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 12/2/2012
 * Time: 8:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BonusSwich
{
	class Program
	{
		public static void Main(string[] args)
		{
  
        byte number;
        Console.Write("Please enter number (1...9): ");
        bool input = byte.TryParse(Console.ReadLine(), out number);
        switch (number)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("\nBonus score is: " + number * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("\nBonus score is: " + number * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("\nBonus score is: " + number * 1000);
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}