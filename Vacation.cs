using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            switch (type)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            if (people >= 30)
                            {
                                price = people * 8.45 * 0.85;
                            }
                            else
                            {
                                price = people * 8.45;
                            }
                            break;
                        case "Saturday":
                            if (people >= 30)
                            {
                                price = people * 9.80 * 0.85;
                            }
                            else
                            {
                                price = people * 9.80;
                            }
                            break;
                        case "Sunday":
                            if (people >= 30)
                            {
                                price = people * 10.46 * 0.85;
                            }
                            else
                            {
                                price = people * 10.46;
                            }
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            if (people >= 100)
                            {
                                price = (people - 10) * 10.90;
                            }
                            else
                            {
                                price = people * 10.90;
                            }
                            break;
                        case "Saturday":
                            if (people >= 100)
                            {
                                price = (people - 10) * 15.60;
                            }
                            else
                            {
                                price = people * 15.60;
                            }
                            break;
                        case "Sunday":
                            if (people >= 100)
                            {
                                price = (people - 10) * 16;
                            }
                            else
                            {
                                price = people * 16;
                            }
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            if (people >= 10 && people <= 20)
                            {
                                price = people * 15 * 0.95;
                            }
                            else
                            {
                                price = people * 15;
                            }
                            break;
                        case "Saturday":
                            if (people >= 10 && people <= 20)
                            {
                                price = people * 20 * 0.95;
                            }
                            else
                            {
                                price = people * 20;
                            }
                            break;
                        case "Sunday":
                            if (people >= 10 && people <= 20)
                            {
                                price = people * 22.50 * 0.95;
                            }
                            else
                            {
                                price = people * 22.50;
                            }
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
