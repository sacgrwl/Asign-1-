using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        const int maxAttempts = 3;

        while (attempts < maxAttempts)
        {
            if (Login())
            {
                Console.WriteLine("Login Successful");
                break;
            }
            else
            {
                attempts++;
                if (attempts < maxAttempts)
                {
                    Console.WriteLine($"Credential incorrect. You have {maxAttempts - attempts} attempts remaining.");
                }
            }
        }

        if (attempts == maxAttempts)
        {
            Console.WriteLine("Maximum attempts reached. Access denied.");
        }
    }

    static bool Login()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        if (username == "Admin" && password == "Admin1234!")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
