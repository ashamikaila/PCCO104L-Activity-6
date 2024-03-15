using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter activity number (1-5) or '0' to exit:");
            string input = Console.ReadLine();
            int activityNumber;

            if (!int.TryParse(input, out activityNumber))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (activityNumber)
            {
                case 0:
                    Console.WriteLine("Exiting program...");
                    return;
                case 1:
                    Activity1();
                    break;
                case 2:
                    Activity2();
                    break;
                case 3:
                    Activity3();
                    break;
                case 4:
                    Activity4();
                    break;
                case 5:
                    Activity5();
                    break;
                default:
                    Console.WriteLine("Activity does not exist.");
                    break;
            }
        }
    }

    static void Activity1()
    {
        Console.WriteLine("Enter amount of money (0.01, 0.05, 0.25, 1, 5, 10, 20, 50, 100, 200, 500, 1000): ");
        string DenominationEntered = Console.ReadLine();

        if (decimal.TryParse(DenominationEntered, out decimal amount))
        {
            string person = DeterminePerson(amount);
            if (person != null)
            {
                Console.WriteLine($"{person} is found in PHP {amount}.");
            }
            else
            {
                Console.WriteLine($"No person found in PHP {amount}.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid Denomination: {DenominationEntered}");
        }
    }

    static string DeterminePerson(decimal amount)
    {
        if (amount == 0.01m || amount == 0.05m || amount == 0.25m)
            return "No person";
        else if (amount == 1m)
            return "Jose Rizal";
        else if (amount == 5m)
            return "Emilio Aguinaldo";
        else if (amount == 10m)
            return "Andres Bonifacio & Apolinario Mabini";
        else if (amount == 20m)
            return "Manuel L. Quezon";
        else if (amount == 50m)
            return "Sergio Osmena";
        else if (amount == 100m)
            return "Manuel Roxas";
        else if (amount == 200m)
            return "Diosdado Macapagal";
        else if (amount == 500m)
            return "Benigno Aquino Sr. & Corazon Aquino";
        else if (amount == 1000m)
            return "Jose Abad Santos, Josefa Escoda, & Vicente Lim";
        else
            return "Invalid Denomination";
    }

    static void Activity2()
    {
        int x = 30;

        for (int i = 1; i <= x; i++)
        {
            string output = "";
            if (i % 3 == 0) output += "Foo";
            if (i % 5 == 0) output += "Bar";

            if (output == "")
            {
                output = i.ToString();
            }
            else
            {
                output = $"{i} - {output}";
            }

            Console.WriteLine(output);
        }
    }

    static void Activity3()
    {
        string input = "";
        string output = "";

        Console.WriteLine("Enter something:");

        while (true)
        {
            input = Console.ReadLine();
            if (input == "exit")
            {
                Console.WriteLine("Closing program....");
                break;
            }
            else
            {
                output += input + "  ";
                Console.WriteLine(output);
            }
        }
    }

    static void Activity4()
    {
        int number;

        do
        {
            Console.Write("Enter a number (0 to exit): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number < 0)
            {
                Console.WriteLine($"Invalid value: {input}");
                Console.WriteLine();
                continue;
            }
            else if (number == 0)
            {
                Console.WriteLine("Closing program...");
                return;
            }

            TreeStar(number);
            Console.WriteLine();

        } while (true);
    }

    static void TreeStar(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Activity5()
    {
        int sum = 0;
        string message = "";
        string input = "";

        while (input != "exit")
        {
            Console.Write("Enter something: ");
            input = Console.ReadLine();

            int number;
            bool isValidNum = int.TryParse(input, out number);

            switch (isValidNum)
            {
                case true:
                    sum += number;
                    Console.WriteLine($"Adding {number} to {sum - number} = {sum}");
                    Console.WriteLine();
                    break;
                case false:
                    message += input;
                    Console.WriteLine($"Current Message is: {message}");
                    Console.WriteLine();
                    break;
            }
        }

        Console.WriteLine("Closing Program...");
    }
}
