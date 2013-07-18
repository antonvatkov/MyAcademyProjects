/*
*A company has name, address, phone number, fax number, web site and manager. 
*The manager has first name, last name, age and a phone number.
*Write a program that reads the information about a company and its manager and prints them on the console.
*/
using System;
class PrintCompanyData
{
	public static void Main()
	{
		Console.WriteLine("Please enter company name.");
		string companyName= Console.ReadLine();
	    Console.WriteLine("Please enter address.");
	    string address = Console.ReadLine();
	    Console.WriteLine("Please enter phone number.");
	    string phoneNumber = Console.ReadLine();
	    Console.WriteLine("Please enter company fax number.");
	    string faxNumber = Console.ReadLine();
	    Console.WriteLine("Please enter company webSite.");
	    string webSite = Console.ReadLine();
	    Console.WriteLine("Please enter company manager first name.");
	    string managerFirstName = Console.ReadLine();
	    Console.WriteLine("Please enter company manager last name.");
	    string managerLastName = Console.ReadLine();
	    Console.WriteLine("Please enter company manager age.");
	    sbyte age = sbyte.Parse(Console.ReadLine());
	    Console.WriteLine("Please enter company manager phone number.");
	    string managerPhoneNumber = Console.ReadLine();
	    Console.WriteLine("The company name is: {0}", companyName);
	    Console.WriteLine("Address: {0}", address);
	    Console.WriteLine("Phone number: {0}", phoneNumber);
	    Console.WriteLine("Fax number: {0}", faxNumber);
	    Console.WriteLine("Web site: {0}", webSite);
	    Console.WriteLine("Manager first name: {0}", managerFirstName);
	    Console.WriteLine("manager last name: {0}", managerLastName);
	    Console.WriteLine("Manager age: {0}", age);
	    Console.WriteLine("Manager Phone Number: {0}", managerPhoneNumber);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
