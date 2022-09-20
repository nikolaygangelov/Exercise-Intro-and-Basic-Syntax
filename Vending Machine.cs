using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            string command = Console.ReadLine();
            double sumOfMoney = 0;
            while (command != "Start")
            {
                input = double.Parse(command);
                if(input !=0.1 && input !=0.2 && input !=0.5 && input !=1 && input != 2)
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                else
                {
                    sumOfMoney += input;
                }
                command = Console.ReadLine();
                if (command == "Start")
                {
                    
                    string command2;
                    while ((command2 = Console.ReadLine()) != "End")
                    {
                        if (command2 != "Nuts" && command2 != "Water" && command2 != "Crisps" && command2 != "Soda" && command2 != "Coke")
                        {
                            Console.WriteLine("Invalid product");
                        }
                        else
                        {
                            if (command2 == "Nuts")
                            { 
                                if (sumOfMoney >= 2.0)
                                {
                                    Console.WriteLine($"Purchased Nuts");
                                    sumOfMoney -= 2.0;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                            }
                            else if (command2 == "Water")
                            {
                                if (sumOfMoney >= 0.7)
                                {
                                    Console.WriteLine($"Purchased Water");
                                    sumOfMoney -= 0.7;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                            }
                            else if (command2 == "Crisps")
                            {
                                if (sumOfMoney >= 1.5)
                                {
                                    Console.WriteLine($"Purchased Crisps");
                                    sumOfMoney -= 1.5;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                            }
                            else if (command2 == "Soda")
                            {
                                if (sumOfMoney >= 0)
                                {
                                    Console.WriteLine($"Purchased Soda");
                                    sumOfMoney -= 0.8;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                            }
                            else if (command2 == "Coke")
                            {
                                if (sumOfMoney >= 1.0)
                                {
                                    Console.WriteLine($"Purchased Coke");
                                    sumOfMoney -= 1.0;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                            }
                            
                        }
                    }
                    Console.WriteLine($"Change: {sumOfMoney:f2}");
                }
            }
            

        }
    }
}
