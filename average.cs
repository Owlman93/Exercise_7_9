/*
*(c) IES San Vicente 2020
*
*Program that calculates the average of a set of marks until the User types "end"
*/
using System;
public class Average
{
	public static void Main()
	{
		Double n1=0, n2, counter=0, result;
		String s;

		Console.Write("Insert a mark: ");
		s=Console.ReadLine();
		
		While(s != "end")
		{ 
			n2=Convert.ToDouble(s);
			counter++;   
			n1+=n2;  // sum of all the notes
		
			Console.Write("Insert a mark: ");
			s=Console.ReadLine();
		}
		If(counter!=0)
		{
			result = n1/counter;
			Console.WriteLine("The average is {0}.",result);
		}
	}
}
