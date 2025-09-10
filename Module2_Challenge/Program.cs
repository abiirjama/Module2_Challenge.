using System;
namespace Module2_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for the number of miles driven
            Console.Write("enter the number of miles driven:");
            double milesdriven = Convert.ToDouble(Console.ReadLine());

            //ask the user for the number of gallons used 
            Console.Write("enter the number of gallons of gasoline used: ");
            double gallonsUsed = Convert.ToDouble(Console.ReadLine());
            //calculate MPG using the formula:miles driven /gallons used
            double mpg = milesdriven / gallonsUsed;

            //display the result to the user
            Console.WriteLine("your car's MPG is: " + mpg);

        
            
        }
    
    }
}