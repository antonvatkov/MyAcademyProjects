/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/18/2012
 * Time: 5:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace factorielNandKSecond
class factorielNandKSecond
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a value for \"N\" factoriel");
			double myFactorielN=double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter a value for \"K\" factoriel");
			double myFactorielK=double.Parse(Console.ReadLine());
			double factorielNMirror = myFactorielN;
			double factorielKMirror = myFactorielK;
			double factorielN=1d;
			double factorielK=1d;
			if (!(1<myFactorielN)&&(1<myFactorielK))
			{
				Console.WriteLine("error");
			}
			else
			{
			if(!(myFactorielN<myFactorielK))
			{
				Console.WriteLine("error");
			}
			else
			{
				do
				{
				 factorielN *= myFactorielN;
			 		myFactorielN--;
				}while(myFactorielN>0);
				Console.WriteLine("N! = " + factorielN);
				do
				{
				 factorielK *= myFactorielK;
			 		myFactorielK--;
				}while(myFactorielK>0);
				Console.WriteLine("K! = " + factorielK);
				double myResult= ((factorielN*factorielK)/(factorielKMirror-factorielNMirror));
				Console.WriteLine(myResult);	
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}