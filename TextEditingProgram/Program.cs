using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to text editing program!");

        while (true)
        {
            Console.WriteLine("What do you want to do? Choose one");
            Console.WriteLine("1. Reverse text");
            Console.WriteLine("2. Concert to uppercase");
            Console.WriteLine("3. Concert to lowercase");
            Console.WriteLine("4. Close program");

            char choise = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choise)
            {
                case '1':
                    Console.WriteLine("Write the text you want to reverse:");
                    string input1 = Console.ReadLine();
                    string reversedText = ReverseText(input1);
                    Console.WriteLine("Reversed text: " + reversedText);
                    break;

                case '2':
                    Console.WriteLine("Write the text you want to uppercase:");
                    string input2 = Console.ReadLine();
                    string uppercaseText = ConvertToUppercase(input2);
                    Console.WriteLine("Converted to uppercase: " + uppercaseText);
                    break;

                case '3':
                    Console.WriteLine("Write the text you want to lowercase:");
                    string input3 = Console.ReadLine();
                    string lowercaseText = ConvertToLowercase(input3);
                    Console.WriteLine("Converted to lowercase: " + lowercaseText);
                    break;

                case '4':
                    Console.WriteLine("Program is shutting down, have a nice day!");
                    return;

                default:
                    Console.WriteLine("Invalid choise. Please choose 1, 2, 3 or 4.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static string ReverseText(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static string ConvertToUppercase(string input)
    {
        return input.ToUpper();
    }

    static string ConvertToLowercase(string input)
    {
        return input.ToLower();
    }
}
