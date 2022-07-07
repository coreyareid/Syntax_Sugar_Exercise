using System;
namespace Syntax_Sugar_Exercise
{
    internal class SyntaxExercise
    {
       public static void Syntax_Exercise()

        {
            int answer = 4;

            string response = (answer < 9)
                ? answer + " is less than nine "
                : answer + " is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}

