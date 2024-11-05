/*

Authored by: Pearl Walker
Course: IGME.201.01
Date: 13 October 2024

*/

namespace gradecalculator {

internal class Program
{

        static void Main()
        {

            //Declare string var studentname
            string studentname = "Pearl";

            // Declare 1D array, 10 integers long
            int[] grades = {100, 92, 87, 2000, -20, 52, 82, 75, 67, 88};

            //Int to count grades values within range
            int values = 0;

        // Declare average, init to 0
        float average = 0;

        //Greet student, give grades
        Console.WriteLine("WELCOME " + studentname + ", YOU WONT ACADEMIC YOU.");
        Console.WriteLine("It seems you've taken " + grades.Length + " classes!");

        //Loop through grades[]
        foreach (int i in grades)
        {

            if (i <= 100 && i >= 90)
            {
                
            if (i == 100)
                    {
                        //if grade is between 90 to 100 w nested if condition for 100%
                        Console.WriteLine(i + " is an A!");
                        Console.Write("And not only an A, but a perfect score!\n");
                } else
                    {
                        Console.WriteLine(i + " is an A!");
                    }

            }
            else if (i < 90 && i >= 80)
            {
                //if grade is between 80 and 90
                Console.WriteLine(i + " is a B.");

            }
            else if (i < 80 && i >= 70)
            {
                //if grade is between 70 and 80
                Console.WriteLine(i + " is a C.");

            }
            else if (i < 70 && i >= 65)
            {
                //if grade is between 65 and 70
                Console.WriteLine(i + " is a D.");

            }
            else if (i < 65 && i >= 0)
            {
                //if grade is between 65 and 0
                Console.WriteLine(i + " is an F.");

            }
            else if (i > 100 || i < 0)
            {
                //outside of the range of 0-100
                Console.WriteLine(i + " is...impossible?");

            }
            else
            {
                //if somehow grade is none of these value(?)
                Console.WriteLine("My code has failed or an improper value was put in grades. Drat.");
            }

        }
        //calculate average, exclude outliers
        foreach(int i in grades)
            {
                if (i <= 100 && i >= 0)
                {
                    Console.WriteLine(i);
                    average = average + i;
                    values++;
                    Console.WriteLine(values);
                } else
                {
                    //
                }
            }

        // get the average from average
        average = average / values;

        Console.WriteLine("Well " + studentname + ", it seems your average grade is " + average + ".");
        if (average == 100)
        {
            Console.Write(" On average, it seems you're pretty perfect, " + studentname + "! :D\n");
        }

        Console.WriteLine("All grades for " + studentname + " have been displayed. Have a nice day!");
    }

}

}