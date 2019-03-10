using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ask user for input
			Console.WriteLine("What is the temperature in fahrenheit?");
			//read fahrenheit input
			string temp = Console.ReadLine();
			int x = Int32.Parse(temp);
			//fahrenheit to Celsius conversion
			int y = x - 32;
			double z = y * 0.5556;
			//print out whether it's hot or cold
			Console.WriteLine("It is " + z + " degrees Celsius!");
			if (z > 23)
			{
				Console.WriteLine("That's hot!");
			}

			else if (z <= 12)
			{
				Console.WriteLine("That's cold!");
			}
			else if (z > 12 || z <= 23)
			{
				Console.WriteLine("Such a nice day!");
			}

			//Wait for user to exit console
			Console.ReadKey();


		}
	}
}
