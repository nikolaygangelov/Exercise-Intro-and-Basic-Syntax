using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            

            string password = string.Empty;
            int counter = 0;


            for (int i = username.Length - 1; i >= 0; i--)
            {
                char letter = username[i];
                password += letter;    
            }
            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password)
            {
                if (enteredPassword != password)
                {
                    counter++;
                    if (counter >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                    
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                }
            }
            if (counter < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
