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
            int[] grades = {100, 92, 87, 200, -20, 52, 82, 75, 67, 88};

        // Declare average, init to 0
        int average = 0;

        //Greet student, give grades
        Console.WriteLine("WELCOME " + studentname + ", YOU WONT ACADEMIC YOU.");
        Console.WriteLine("Here are your grades:");

        //Loop through grades[]
        foreach (int i in grades)
        {

            //add grade value to var each iteration
            average = average + i;
            //Console.WriteLine("average + " + i + " = " + average);

            if (i <= 100 && i >= 90)
            {
                //if grade is between 90 to 100 w nested if condition for 100%
                Console.WriteLine(i + ": This grade is an A!");
            if (i == 100)
                {
                    Console.Write(" And not only an A, but a perfect score!\n");
                }

            }
            else if (i < 90 && i >= 80)
            {
                //if grade is between 80 and 90
                Console.WriteLine(i + ": This grade is a B.");

            }
            else if (i < 80 && i >= 70)
            {
                //if grade is between 70 and 80
                Console.WriteLine(i + ": This grade is a C.");

            }
            else if (i < 70 && i >= 65)
            {
                //if grade is between 65 and 70
                Console.WriteLine(i + ": This grade is a D.");

            }
            else if (i < 65 && i >= 0)
            {
                //if grade is between 65 and 0
                Console.WriteLine(i + ": This grade is an F.");

            }
            else if (i > 100 || i < 0)
            {
                //outside of the range of 0-100
                Console.WriteLine(i + ": This grade is ouside of the range of 0-100...How did you get this grade??");

            }
            else
            {
                //if somehow grade is none of these value(?)
                Console.WriteLine("My code has failed or an improper value was put in grades. Drat.");
            }

        }

        // get the average from average
        average = average / 10;

        Console.WriteLine("Well " + studentname + ", it seems your average grade is " + average + ".");
        if (average == 100)
        {
            Console.Write(" On average, it seems you're pretty perfect, " + studentname + "! :D\n");
        }

        Console.WriteLine("All grades for " + studentname + " have been displayed. Have a nice day!");
    }

}

}