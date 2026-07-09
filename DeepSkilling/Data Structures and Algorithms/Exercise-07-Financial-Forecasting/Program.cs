using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentValue = 10000;
            double growthRate = 0.10; // 10%
            int years = 5;

            Console.WriteLine("===== Financial Forecasting =====\n");

            Console.WriteLine($"Current Value : ₹{currentValue}");

            Console.WriteLine($"Annual Growth Rate : {growthRate * 100}%");

            Console.WriteLine($"Forecast Period : {years} Years\n");

            double futureValue = FinancialForecast.PredictFutureValue(currentValue, growthRate, years);

            Console.WriteLine($"Predicted Future Value : ₹{futureValue:F2}");

            Console.WriteLine("\nTime Complexity : O(n)");

            Console.WriteLine("Space Complexity : O(n) (Recursive Call Stack)");

            Console.WriteLine("\nOptimization:");

            Console.WriteLine("- Memoization can reduce repeated computations.");

            Console.WriteLine("- An iterative solution avoids recursive call stack overhead.");
        }
    }
}