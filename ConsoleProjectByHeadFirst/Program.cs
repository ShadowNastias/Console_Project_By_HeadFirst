using System;

namespace ConsoleProjectByHeadFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
            Console.WriteLine( );
            
            //Loops
            Console.WriteLine(Loops.TryIf());
            Console.WriteLine(Loops.TryIfElse());
            Console.WriteLine(Loops.TryWhileFor());
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;
            int heigh = 2 + 4;
            int area = width * heigh;

            string result = "The area";
            result = result + " is " + area;

            bool truthValue = true;

            do
            {
                width--;
                Console.WriteLine("width = " + width);
                Console.ReadLine();
                
                area = width * heigh;
                Console.WriteLine("area = " + area);
                Console.ReadLine();
            } while (area > 25);
        }
    }
}