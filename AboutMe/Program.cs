using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] results = { 0, 5 };
            results = QuizMgr(results);
        }

        static int[] QuizMgr(int[] results)
        {
            
            // returns array with [correct, incorrect]
            return results;
        }

        static bool QDegree()
        {
            bool response = false; // yes=true, no=false (incorrect is default)
            Console.WriteLine("Have I earned a bachelor's degree? (Please enter 'yes' or 'no'");
            string rawResponse = Console.ReadLine();
            if(rawResponse.ToLower() == "yes" || rawResponse.ToLower() == "y")
            {
                response = true;
            }

            return response;
        }

        static bool QAerospace()
        {
            bool response; // yes=true, no=false
            Console.WriteLine("As an engineer, have I worked only in aerospace? (Please enter 'yes' or 'no'");
            string rawResponse = Console.ReadLine();
            return response;
        }

        static int QYearsAtBoeing()
        {
            int response; // number of years
            Console.WriteLine("How many (whole) years did I work at Boeing? (Please enter a number. You have 3 guesses.");
            string rawResponse = Console.ReadLine();
            return response;
        }

        static string QCFGrad()
        {
            string response; // name of month
            Console.WriteLine("During which month in 2019 will I graduate from Code Fellows?");
            string rawResponse = Console.ReadLine();
            return response;
        }

        static int QRetire()
        {
            int response; // year
            Console.WriteLine("In what year do I intend to retire?");
            string rawResponse = Console.ReadLine();
            return response;
        }

    }
}
