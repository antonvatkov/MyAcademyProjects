using System;


class Program
{
    static void Main()
    {
        
        ulong myFactorielN = 1;
        ulong myProductN = 1;
       
        for (ulong myN = 0; myN < 35; myN++)        
        {
            myProductN = myFactorielN = 1;
            for (ulong i = 1; i < myN; i++)           
            {
                myProductN *= (i+1 + myN); //sharp develop no big integer:(
                myFactorielN *= i + 1;
            }
            Console.WriteLine("Result({1}) = {0}", myProductN / myFactorielN, myN);
        }

    }
}