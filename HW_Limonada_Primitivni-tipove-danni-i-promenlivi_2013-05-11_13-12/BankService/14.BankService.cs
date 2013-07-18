/*
 * A bank account has a holder name (first name, middle name and last name), .
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account
 */
using System;
class BankService
{
    static void Main()
    {
        string firstName = "Tony";
        string middleName = "Jose";
        string lastName = "Nadal";
        decimal balance = 1000000;
        string bankName = "OBB";
        string IBAN = null;
        string BIC = null;
        ulong debitCard1 = 0;
        ulong debitCard2 = 500000;
        ulong debitCard3 = 500000;
    	Console.WriteLine(" FirstName:{0}\r\n MiddleName:{1}\r\n LastName:{2}\r\n balance:{3}\r\n bankName:{4}\r\n IBAN:{5}\r\n BIC:{6}\r\n debitCard1:{7}\r\n debitCard2:{8}\r\n debitCard3:{9}"
                          ,firstName,middleName,lastName,balance,bankName,IBAN,BIC,debitCard1,debitCard2,debitCard3);
        Console.Write("Press any key to continued . . . ");
		Console.ReadKey(true);
    }
}