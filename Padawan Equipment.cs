

namespace _09._Padawan_Equipment
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //    •	The amount of money John has – floating - point number in the range[0.00…1000.00].
            double money = double.Parse(Console.ReadLine());
            //    •	The count of students – integer in the range[0…100].
            int countOfStudents = int.Parse(Console.ReadLine());
            //    •	The price of lightsabers for a single saber – floating - point number in the range[0.00…100.00].
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            //    •	The price of robes for a single robe – floating - point number in the range[0.00…100.00].
            double priceOfRobe = double.Parse(Console.ReadLine());
            //    •	The price of belts for a single belt – floating - point number in the range[0.00…100.00].
            double priceOfBelt = double.Parse(Console.ReadLine());

            int freeBelts = countOfStudents / 6;
            double costOfEquipment = (countOfStudents + Math.Ceiling(0.1 * countOfStudents) )* priceOfLightsaber + countOfStudents * priceOfRobe + (countOfStudents - freeBelts) * priceOfBelt;
            //•	Every sixth belt is free.
            if (costOfEquipment <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {costOfEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {costOfEquipment-money:f2}lv more.");
            }
        }
    }
}
