using System;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shoes", "Fashion"),
                new Product(103, "Mobile", "Electronics"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")
            };

            Console.WriteLine("====== LINEAR SEARCH ======");

            Product? linearResult = SearchAlgorithms.LinearSearch(products, 103);

            if (linearResult != null)
            {
                linearResult.Display();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine();

            Console.WriteLine("====== BINARY SEARCH ======");

            Product? binaryResult = SearchAlgorithms.BinarySearch(products, 103);

            if (binaryResult != null)
            {
                binaryResult.Display();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine();

            Console.WriteLine("Time Complexity Analysis");
            Console.WriteLine("Linear Search : O(n)");
            Console.WriteLine("Binary Search : O(log n)");
            Console.WriteLine();
            Console.WriteLine("Binary Search is more efficient for large sorted datasets.");
        }
    }
}