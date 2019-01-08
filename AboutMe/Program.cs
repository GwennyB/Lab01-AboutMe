using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] results = { 0, 0 }; // establish results tallying array
            results = QuizMgr(results); // launch QuizMgr
            Console.WriteLine($"\nYou answered {results[0]} questions correctly and {results[1]} questions incorrectly."); // final results
            Console.ReadLine(); // wait for the user to be done reading
        }

        // QuizMgr acts as an intermediary between Main and the user. It initiates each quiz question, tallies results to return to Main, and gives more details on each topic.
        static int[] QuizMgr(int[] results)
        {
            // launch question
            if (QDegree() == true)
            {
                results[0]++;
                Console.Write("Correct!  ");
            }
            else
            {
                results[1]++;
                Console.Write("Oops...wrong.  ");
            }
            // Q1 feedback
            Console.WriteLine("I earned a BS in Mechanical Engineering from The University of Texas at Austin.");
            Console.ReadLine();

            // launch question
            if (QAerospace() == false)
            {
                results[0]++;
                Console.Write("Correct!  ");
            }
            else
            {
                results[1]++;
                Console.Write("Oops...wrong.  ");
            }
            // Q2 feedback
            Console.WriteLine("I've had a pretty full career. In addition to aerospace, I've worked as a designer/engineer in industrial food processing equipment, silicon wafer processing products, military specialty tools research and development, and heavy equipment.");
            Console.ReadLine();

            // launch question
            if (QYearsAtBoeing() == 11)
            {
                results[0]++;
                Console.Write("Correct!  ");
            }
            else
            {
                results[1]++;
                Console.Write("Oops...wrong.  ");
            }
            // Q3 feedback
            Console.WriteLine("I worked at Boeing for just over 11 years in total. Although I grew beyond Boeing, I wouldn't trade that experience for the world.");
            Console.ReadLine();

            // launch question
            if (QCFGrad().ToLower() == "march")
            {
                results[0]++;
                Console.Write("Correct!  ");
            }
            else
            {
                results[1]++;
                Console.Write("Oops...wrong.  ");
            }
            // Q4 feedback
            Console.WriteLine("I will present with my final project group on March 15, and I'll be a proud Code Fellows .NET graduate a few days after!");
            Console.ReadLine();

            // launch question
            if (QRetire() == 2026)
            {
                results[0]++;
                Console.Write("Correct!  ");
            }
            else
            {
                results[1]++;
                Console.Write("Oops...wrong.  ");
            }
            // Q5 feedback
            Console.WriteLine("I fully intend to retire early in 7 years, just after my birthday in 2026.");
            Console.ReadLine();

            // returns array with [correct, incorrect]
            return results;
        }

        // question with response conditioning
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

        // question with response conditioning
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

        // question with response conditioning and data type validation
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
                Console.WriteLine("ERROR: That's not a number. Sorry!\n");
            }
            return response;
        }

        // question with response conditioning
        static string QCFGrad()
        {
            string response = ""; // name of month (incorrect "" is default)
            Console.WriteLine("\nDuring which month in 2019 will I graduate from Code Fellows?");
            string rawResponse = Console.ReadLine();
            response = rawResponse;
            return response;
        }

        // question with response conditioning and data type validation
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
                Console.WriteLine("ERROR: That's not a numeric year. Sorry!\n");
            }
            return response;
        }

    }
}
