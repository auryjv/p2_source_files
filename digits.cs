using System;

class digits
{
    static void Main()
    {
        int units = 0, tens = 0, hundreds = 0, thousandsOrMore = 0;
        Console.Write("Insert a number: ");
        string userInput = Console.ReadLine();// read the number as string to check the word "end"
        while(userInput!="end"){
            int input = Convert.ToInt32(e);
            if(input != 0){
                if(input/10 == 0)
                    units ++;  
                else 
                    if (input/100 == 0)
		                tens ++;  
                    else
                        if (input/1000 == 0)
                            hundreds ++;  
                        else
                            thousandsOrMore++;  
            }
            userInput = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", units, tens, hundreds, thousandsOrMore); 
     }
}

