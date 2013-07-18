/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/18/2012
 * Time: 8:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace calculateSum
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a value for \"N\" factoriel");
			double myFactorielN=double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter a value for \"X\" factoriel");
			double myFactorielK=double.Parse(Console.ReadLine());
			double zeroDouble= 0d;
			double myFactorielNMirror=myFactorielN;
			double mySumResult=0d;
			if (myFactorielN <= 0)
			{
				Console.WriteLine("error");
			}
			if (myFactorielK <=0) 
			{
				Console.WriteLine("Result is:" + (myFactorielN/zeroDouble));
			}
			while (myFactorielNMirror != 1) 
			{
				myFactorielNMirror--;
				mySumResult += ((myFactorielN*myFactorielNMirror)/(myFactorielN*myFactorielK));
			}
			Console.WriteLine("The result is:"+ mySumResult);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}