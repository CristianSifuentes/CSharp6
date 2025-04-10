using System;
using static System.Console;
using static System.Math;


namespace CSharp6FeaturesDemo
{
    // Class demonstrating Expression-Bodied Members and Interpolated Strings
    public class Product
    {
        // Automatic Properties
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor using Expression-Bodied Member
        public Product(string name, decimal price) => (Name, Price) = (name, price);

        // ToString overridden with Expression-Bodied Member
        public override string ToString() => $"Product: {Name}, Price: {Price:C}";
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 6.0 Features Demo");

            // 1. Interpolated Strings
            var product = new Product("Laptop", 1500.00m);
            Console.WriteLine($"\nUsing Interpolated Strings: The {product.Name} costs {product.Price:C}.");

            // 2. Null-Conditional Operator
            Product nullProduct = null;

            // Safe access using null-conditional operator
            var productName = nullProduct?.Name;
            Console.WriteLine("\nUsing Null-Conditional Operator:");
            Console.WriteLine($"Product name: {productName ?? "No product available"}"); // Fallback using null-coalescing

            // Chaining null-conditional operators
            var upperCaseName = nullProduct?.Name?.ToUpper();
            Console.WriteLine($"Upper-case product name: {upperCaseName ?? "No product available"}");

            // 3. Expression-Bodied Members
            Console.WriteLine("\nUsing Expression-Bodied Members:");
            Console.WriteLine(product);

           //Static Using Directives
            Console.WriteLine("Using static using directive");// using static method from System.Console 
            double result = Math.Pow(2, 3); // Using static method from System.Math
            WriteLine($"2 raised to the power of 3 is {result}.");// not using static method from System.Console 
            double squareRoot = Pow(2, 3); // Not using static method from System.Math

            Console.WriteLine("\nC# 6.0 Features Demonstrated Successfully!");

            using (var r = new Resource())
            {
                Console.WriteLine("Using the resource...");
            }

            // Force GC for educational purposes only (not recommended in production)
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
