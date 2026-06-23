using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Application Started");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Processing Data");

            Console.WriteLine();

            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Singleton Pattern Verified.");
                Console.WriteLine("Both logger objects refer to the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton Pattern Failed.");
            }
        }
    }
}