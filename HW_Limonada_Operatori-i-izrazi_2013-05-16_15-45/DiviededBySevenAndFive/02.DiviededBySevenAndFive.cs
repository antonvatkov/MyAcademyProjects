﻿/*
 * Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */
using System;
class DiviededBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Plase enter an intiger number");
        int number = int.Parse(Console.ReadLine());
        if(number % 35 == 0)
        {
            Console.WriteLine("The number can be dived by 5 and 7");
        }
        else
        {
            Console.WriteLine("The number cannot be dived by 5 and 7");
        }
	Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}
