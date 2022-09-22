using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = (countOfLostGames / 2) * headsetPrice + (countOfLostGames / 3) * mousePrice + (countOfLostGames / 6) * keyboardPrice + (countOfLostGames / 6 / 2) * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
