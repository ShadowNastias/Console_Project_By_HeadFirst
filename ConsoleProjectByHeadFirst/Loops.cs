using System;

namespace ConsoleProjectByHeadFirst
{
    public class Loops
    {
        public string tryAnIf = TryIf();
        public string tryAnIfElse = TryIfElse();
        public string trySomeLoops = TryWhileFor();

        public Loops(string aTryAnIf, string aTryAnIfElse, string aTrySomeLoops)
        {
            tryAnIf = aTryAnIf;
            tryAnIfElse = aTryAnIfElse;
            trySomeLoops = aTrySomeLoops;
        }
        
        public static string TryIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            string result;

            if ((someValue == 3) && (name == "Joe"))
            {
               Console.WriteLine("x is 3 and the name is Joe");
               result = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("this line runs no matter what"); 
                result = Console.ReadLine();
            }

            return result;
        }

        public static string TryIfElse()
        {
            int x = 5;
            string result;
            
            if (x == 10)
            {
                 Console.WriteLine("x must be 10");
                 result = Console.ReadLine();
            }
            else
            {
                 Console.WriteLine("x isn't 10");
                 result = Console.ReadLine();
            }

            return result;
        }
        public static string TryWhileFor()
        {
            int count = 0;
            string result;
            
            while (count < 10) 
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            { 
                count = count - 1;
            }

            Console.WriteLine("The answer is " + count);
            result = Console.ReadLine();
            return result;
        }
    }
}
