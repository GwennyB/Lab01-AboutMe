using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] results = { 0, 0 };
            results = QuizMgr(results);
            Console.WriteLine($"\nYou answered {results[0]} questions correctly and {results[1]} questions incorrectly.");
            Console.ReadLine();
        }

        static int[] QuizMgr(int[] results)
        {
            if (QDegree() == true)
            {
                results[0]++;
            }
            else
            {
                results[1]++;
            }
            // Q1 feedback
            Console.WriteLine("I earned a BS in Mechanical Engineering from The University of Texas at Austin.");
            Console.WriteLine($"correct: {results[0]}    incorrect: {results[1]}");
            Console.ReadLine();

            if (QAerospace() == false)
            {
                results[0]++;
            }
            else
            {
                results[1]++;
            }
            // Q2 feedback
            Console.WriteLine("I've had a pretty full career. In addition to aerospace, I've worked as a designer/engineer in industrial food processing equipment, silicon wafer processing products, military specialty tools research and development, and heavy equipment.");
            Console.WriteLine($"correct: {results[0]}    incorrect: {results[1]}");
            Console.ReadLine();

            if (QYearsAtBoeing() == 11)
            {
                results[0]++;
            }
            else
            {
                results[1]++;
            }
            // Q3 feedback
            Console.WriteLine("I worked at Boeing for just over 11 years in total. Although I grew beyond Boeing, I wouldn't trade that experience for the world.");
            Console.WriteLine($"correct: {results[0]}    incorrect: {results[1]}");
            Console.ReadLine();

            if (QCFGrad().ToLower() == "march")
            {
                results[0]++;
            }
            else
            {
                results[1]++;
            }
            // Q4 feedback
            Console.WriteLine("I will present with my final project group on March 15, and I'll be a proud Code Fellows .NET graduate a few days after!");
            Console.WriteLine($"correct: {results[0]}    incorrect: {results[1]}");
            Console.ReadLine();

            if (QRetire() == 2026)
            {
                results[0]++;
            }
            else
            {
                results[1]++;
            }
            // Q5 feedback
            Console.WriteLine("I fully intend to retire early in 7 years, just after my birthday in 2026.");
            Console.WriteLine($"correct: {results[0]}    incorrect: {results[1]}");
            Console.ReadLine();

            // returns array with [correct, incorrect]
            return results;
        }

        static bool QDegree()
        {
            bool response = false; // yes=true, no=false (incorrect false is default)
            Console.WriteLine("\nHave I earned a bachelor's degree? (Please enter 'yes' or 'no'.)");
            string rawResponse = Console.ReadLine();
            if(rawResponse.ToLower() == "yes" || rawResponse.ToLower() == "y")
            {
                response = true;
            }

            return response;
        }

        static bool QAerospace()
        {
            bool response = true; // yes=true, no=false (incorrect true is default)
            Console.WriteLine("\nAs an engineer, have I worked only in aerospace? (Please enter 'yes' or 'no'.)");
            string rawResponse = Console.ReadLine();
            if (rawResponse.ToLower() == "no" || rawResponse.ToLower() == "n")
            {
                response = false;
            }
            return response;
        }

        static int QYearsAtBoeing()
        {
            int response = 0; // number of years (incorrect 0 is default)
            Console.WriteLine("\nHow many (whole) years did I work at Boeing? (Please enter a number.)");
            string rawResponse = Console.ReadLine();
            try
            {
                response = Convert.ToUInt16(rawResponse);
            }
            catch
            {
                Console.WriteLine("That's not a number. Sorry!");
            }
            return response;
        }

        static string QCFGrad()
        {
            string response = ""; // name of month (incorrect "" is default)
            Console.WriteLine("\nDuring which month in 2019 will I graduate from Code Fellows?");
            string rawResponse = Console.ReadLine();
            response = rawResponse;
            return response;
        }

        static int QRetire()
        {
            int response = 2019; // year (incorrect 2019 is default)
            Console.WriteLine("\nIn what year do I intend to retire? (Please enter a numeric year.)");
            string rawResponse = Console.ReadLine();
            try
            {
                response = Convert.ToUInt16(rawResponse);
            }
            catch
            {
                Console.WriteLine("That's not a numeric year. Sorry!");
            }
            return response;
        }

    }
}
