/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/29/2012
 * Time: 3:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
 
class digitName
{
    static void Main(string[] args)
    {
 
        Console.WriteLine("Please enter a number");
        int number;
        bool input=int.TryParse(Console.ReadLine(), out number);
        string switchOutput = "";
       	
     
        if (input==true) 
        {
        	
        
        	switch (number)
        		{
 
	            case 0:
	                switchOutput = "Zero";
	                break;
	            case 1:
	                switchOutput = "One";
	                break;
	            case 2:
	                switchOutput = "Two";
	                break;
	            case 3:
	                switchOutput = "Three";
	                break;
	            case 4:
	                switchOutput = "Four";
	                break;
	            case 5:
	                switchOutput = "Five";
	                break;
	            case 6:
	                switchOutput = "Six";
	                break;
	            case 7:
	                switchOutput = "Seven";
	                break;
	            case 8:
	                switchOutput = "Eight";
	                break;
	            case 9:
	                switchOutput = "Nine";
	                break;
	            case 10:
	                switchOutput = "Ten";
	                break;
	            case 11:
	                switchOutput = "Eleven";
	                break;
	            case 12:
	                switchOutput = "Twelve";
	                break;
	            case 13:
	                switchOutput = "Thirteen";
	                break;
	            case 14:
	                switchOutput = "Fourteen";
	                break;
	            case 15:
	                switchOutput = "Fifteen";
	                break;
	            case 16:
	                switchOutput = "Sixteen";
	                break;
	            case 17:
	                switchOutput = "Seventeen";
	                break;
	            case 18:
	                switchOutput = "Eighteen";
	                break;
	            case 19:
	                switchOutput = "Nineteen";
	                break;
	            case 20:
	                switchOutput = "Twenty";
	                break;
	            default:
	                switchOutput = "Invalid Input! Please make sure you entered a right input value";
	                break;
 
	        	}
	 
	    }
        Console.WriteLine("{0}"+"{1}", number, switchOutput);
		Console.ReadKey(true);
		
    }
}