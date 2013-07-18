using System;
 
class SequanceMinMax
{
        static void Main()
        {
                int sequanceLenght;
                int myNumber;
                int myResultmin=0;
                int myResultmax=0;
              
                Console.WriteLine("Please enter the sequance lenght");
                string myTextSequanceLenght = Console.ReadLine();
 
                if (!int.TryParse(myTextSequanceLenght, out sequanceLenght))
                {
                        Console.WriteLine("Invalid number: {0}", myTextSequanceLenght);
                }
 
                for (int i = 0; i < sequanceLenght; i++)
                {
                        Console.WriteLine("Please enter a number.");
                        string myTextNumber = Console.ReadLine();
 
                        if (!int.TryParse(myTextNumber, out myNumber))
                        {
                                Console.WriteLine("Invalid number: {0}", myTextNumber);
                        }
 
                        if (i == 0)
                        {
                                myResultmin = myNumber;
                                myResultmax = myNumber;
                        }
 
                        if (myResultmax < myResultmin)
                        {
                                myResultmin = myNumber;
                        }
 
                        if (myNumber > myResultmax)
                        {
                                myResultmax = myNumber;
                        }
                }
 
                Console.WriteLine("The min number is: {0}", myResultmin);
                Console.WriteLine("The max number is: {0}", myResultmax);
    			Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
        }
}

	
