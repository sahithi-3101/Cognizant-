using System;

namespace SingletonPatternExample
{
    public sealed class Logger
    {
        private static Logger? instance = null;

        private Logger()
        {
            Console.WriteLine("Logger Instance Created");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}