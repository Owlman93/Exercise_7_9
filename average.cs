using System;
public class Average
{
	public static void Main()
	{
		double n1=0, n2, counter=0, result;
		string s;

		Console.Write("Insert a mark: ");
		s=Console.ReadLine();
		
		while(s!="end")
		{ 
			n2=Convert.ToDouble(s);
			counter++;   
			n1+=n2;  // sum of all the notes
		
			Console.Write("Insert a mark: ");
			s=Console.ReadLine();
		}
		if(counter!=0)
		{
			result = n1/counter;
			Console.WriteLine("The average is {0}.",result);
		}
	}
}
