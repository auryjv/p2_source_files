using System;

public class Average
{
	public static void Main()
	{
		double total=0, numberToAdd, numberOfMarks=0, result;
		string userInput;

		Console.Write("Insert a mark: ");
		userInput=Console.ReadLine();	// we read the mark as string to check the word "end"			 
		while(userInput!="end"){
			numberToAdd=Convert.ToDouble(userInput);
			numberOfMarks++;  
			total+=numberToAdd; 
			Console.Write("Insert a mark: ");
			userInput=Console.ReadLine();
		}
		if(numberOfMarks!=0){
			result=total/numberOfMarks; 
			Console.WriteLine("The average is {0}.",result);
		}
	}
}
