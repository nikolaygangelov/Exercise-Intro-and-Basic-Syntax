using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());


            double price = 0;
            double totalPrice = 0;
            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                price = daysInMonth* pricePerCapsule *capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;

            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
