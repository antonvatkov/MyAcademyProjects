/*
*A marketing firm wants to keep record of its employees.
*Each record would have the following characteristics – first name, family name, age, gender (m or f),  
*ID number, unique employee number (27560000 to 27569999).
*Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
*/
using System;
class InfoCompany
{
    static void Main()
    {
        string firstName = "Tony";
        string lastName = "Nadal";
        byte age = 18;
        char gender = 'm';
        long ID = 213125123;
        uint uniqueNumber = 27569999;
    	Console.WriteLine(" FirstName:{0}\r\n LastName:{1}\r\n Age:{2}\r\n Gender:{3}\r\n ID:{4}\r\n UniqueNumber:{5}"
                          ,firstName,lastName,age,gender,ID,uniqueNumber);
        Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}
