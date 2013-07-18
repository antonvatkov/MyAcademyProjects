/*
*Write a program that reads the radius r of a circle and prints its perimeter and area.
*/
using System;
class PrintPerimetre
{
	public static void Main()
	{
		Console.WriteLine("Please enter a integer value for radius");
		int radius=TryToParse(Console.ReadLine());
		if (radius==0) 
		{
			Main();
		}
		CalculateAreaPerimeter(radius);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
//Check input data method
	private static int TryToParse(string value)
   {
      int number;
      bool result = Int32.TryParse(value, out number);
      if (result)
      {
      	number=int.Parse(value);
  		return number;
      }
      else
      { 
      	Console.WriteLine("Please enter a correct data:Input error: {0}", value);
        return 0;
      }
	}
      //Calculate and print method
	public static void CalculateAreaPerimeter(int radius)
	{
		double circumferenceOfCircle=((Math.PI*2)*radius);
		Console.WriteLine(@"The Circumference of Circle is: {0}",circumferenceOfCircle);
		double areaOfCircle=((Math.PI)*(Math.Pow(radius,2)));
		Console.WriteLine(@"The Area of Circle is: {0}",areaOfCircle);
	}
}
