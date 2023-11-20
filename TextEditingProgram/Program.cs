using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the text editing program!");

        while (true)
        {
            Console.WriteLine("What do you want to do? Choose one");
            Console.WriteLine();
            Console.WriteLine("Text Editing Options:");
            Console.WriteLine("1. Reverse text");
            Console.WriteLine("2. Convert to uppercase");
            Console.WriteLine("3. Convert to lowercase");
            Console.WriteLine("4. Convert every other letter");
            Console.WriteLine();
            Console.WriteLine("System options:");
            Console.WriteLine("5. Change console text color");
            Console.WriteLine("6. Change console background color");
            Console.WriteLine("7. Reset the colors. (Both text color and background color)");
            Console.WriteLine("8. Close program");

            Console.WriteLine();
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    Console.WriteLine("Write the text you want to reverse:");
                    string input1 = Console.ReadLine();
                    string reversedText = ReverseText(input1);
                    Console.WriteLine("Reversed text: " + reversedText);
                    Console.WriteLine();
                    break;

                case '2':
                    Console.WriteLine("Write the text you want to convert to uppercase:");
                    string input2 = Console.ReadLine();
                    string uppercaseText = ConvertToUppercase(input2);
                    Console.WriteLine("Converted to uppercase: " + uppercaseText);
                    Console.WriteLine();
                    break;

                case '3':
                    Console.WriteLine("Write the text you want to convert to lowercase:");
                    string input3 = Console.ReadLine();
                    string lowercaseText = ConvertToLowercase(input3);
                    Console.WriteLine("Converted to lowercase: " + lowercaseText);
                    Console.WriteLine();
                    break;

                case '4':
                    Console.WriteLine("Write the text you want to modify (convert every other letter):");
                    string input4 = Console.ReadLine();
                    string modifiedText = ConvertEveryOtherLetter(input4);
                    Console.WriteLine("Modified text: " + modifiedText);
                    Console.WriteLine();
                    break;

                case '5':
                    ChangeConsoleColorPrompt();
                    break;

                case '6':
                    ChangeConsoleBackgroundColorPrompt();
                    break;

                case '7':
                    ResetConsoleColor();
                    break;

                case '8':
                    Console.WriteLine("Program is shutting down. Have a nice day!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose 1, 2, 3, 4, 5, 6, 7 or 8.");
                    Console.WriteLine();
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

    static string ConvertEveryOtherLetter(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i += 2)
        {
            chars[i] = Char.ToUpper(chars[i]);
        }

        return new string(chars);
    }

    static void ChangeConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void ChangeConsoleBackgroundColor(ConsoleColor color)
    {
        Console.BackgroundColor = color;
    }

    static void ResetConsoleColor()
    {
        Console.ResetColor();
    }

    static void ChangeConsoleColorPrompt()
    {
        Console.WriteLine("Choose a color for the console text:");
        ChangeConsoleColor(ConsoleColor.Red);
        Console.WriteLine("1. Red");

        ChangeConsoleColor(ConsoleColor.Green);
        Console.WriteLine("2. Green");

        ChangeConsoleColor(ConsoleColor.Yellow);
        Console.WriteLine("3. Yellow");

        ChangeConsoleColor(ConsoleColor.Blue);
        Console.WriteLine("4. Blue");

        ChangeConsoleColor(ConsoleColor.Magenta);
        Console.WriteLine("5. Magenta");

        ChangeConsoleColor(ConsoleColor.Cyan);
        Console.WriteLine("6. Cyan");

        ChangeConsoleColor(ConsoleColor.White);
        Console.WriteLine("7. White");

        Console.WriteLine("8. Black");
        Console.WriteLine("- Please do note that if you choose this one and you have default (black) background, your text will not be visible");

        ConsoleKeyInfo colorChoice = Console.ReadKey();
        Console.WriteLine();

        switch (colorChoice.Key)
        {
            case ConsoleKey.D1:
                ChangeConsoleColor(ConsoleColor.Red);
                break;

            case ConsoleKey.D2:
                ChangeConsoleColor(ConsoleColor.Green);
                break;

            case ConsoleKey.D3:
                ChangeConsoleColor(ConsoleColor.Yellow);
                break;

            case ConsoleKey.D4:
                ChangeConsoleColor(ConsoleColor.Blue);
                break;

            case ConsoleKey.D5:
                ChangeConsoleColor(ConsoleColor.Magenta);
                break;

            case ConsoleKey.D6:
                ChangeConsoleColor(ConsoleColor.Cyan);
                break;

            case ConsoleKey.D7:
                ChangeConsoleColor(ConsoleColor.White);
                break;

            case ConsoleKey.D8:
                ChangeConsoleColor(ConsoleColor.Black);
                break;

            default:
                Console.WriteLine("Invalid choice. Using default color.");
                break;
        }
    }

    static void ChangeConsoleBackgroundColorPrompt()
    {
        Console.WriteLine("Choose a color for the console background:");
        ChangeConsoleBackgroundColor(ConsoleColor.DarkRed);
        Console.WriteLine("1. DarkRed");

        ChangeConsoleBackgroundColor(ConsoleColor.DarkGreen);
        Console.WriteLine("2. DarkGreen");

        ChangeConsoleBackgroundColor(ConsoleColor.DarkYellow);
        Console.WriteLine("3. DarkYellow");

        ChangeConsoleBackgroundColor(ConsoleColor.DarkBlue);
        Console.WriteLine("4. DarkBlue");

        ChangeConsoleBackgroundColor(ConsoleColor.DarkMagenta);
        Console.WriteLine("5. DarkMagenta");

        ChangeConsoleBackgroundColor(ConsoleColor.DarkCyan);
        Console.WriteLine("6. DarkCyan");

        ChangeConsoleBackgroundColor(ConsoleColor.Gray);
        Console.WriteLine("7. Gray");

        ConsoleKeyInfo colorChoice = Console.ReadKey();
        Console.WriteLine();

        switch (colorChoice.Key)
        {
            case ConsoleKey.D1:
                ChangeConsoleBackgroundColor(ConsoleColor.DarkRed);
                break;

            case ConsoleKey.D2:
                ChangeConsoleBackgroundColor(ConsoleColor.DarkGreen);
                break;

            case ConsoleKey.D3:
                ChangeConsoleBackgroundColor(ConsoleColor.DarkYellow);
                break;

            case ConsoleKey.D4:
                ChangeConsoleBackgroundColor(ConsoleColor.DarkBlue);
                break;

            case ConsoleKey.D5:
                ChangeConsoleBackgroundColor(ConsoleColor.DarkMagenta);
                break;

            case ConsoleKey.D6:
                ChangeConsoleBackgroundColor(ConsoleColor.DarkCyan);
                break;

            case ConsoleKey.D7:
                ChangeConsoleBackgroundColor(ConsoleColor.Gray);
                break;

            default:
                ChangeConsoleBackgroundColor(ConsoleColor.Black);
                Console.WriteLine("Invalid choice. Using default color.");
                break;
        }
    }
}
