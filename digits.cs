/*
*(c) IES San Vicente 2020
*
*Program that calculates how many numbers of 1, 2, 3 or more digits are entered by the User until it types "end"
*/

using System;

	class digits
	{
		 static void Main()
 		{
     			int single = 0, doble = 0, triple = 0, multiple = 0;
      			Console.Write("Insert a number: ");
      			string e = Console.ReadLine();
			 
     			while(e != "end")
     			{
				int input = Convert.ToInt32(e);
     				
				if(input != 0)
				{
       					if(input/10 == 0)
           				single ++;
       					
					else if (input/100 == 0)
					doble ++;
        
					else if (input/1000 == 0)
        				triple ++;
        
					else
           				multiple++;
        			}
      				e = Console.ReadLine();
			}
			 
			Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", single, doble, triple, multiple); 
		}
	}
