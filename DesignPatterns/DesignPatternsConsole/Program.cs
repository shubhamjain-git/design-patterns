using DesignPatternsLibrary;
using System;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedOption = -1;            
          
            while(selectedOption != 0)
            {
                DisplayMainMenu();
                selectedOption = ReadInputFromConsole();
                string patternName;

                switch (selectedOption)
                {
                    case 1:
                        patternName = DesignPatternConstants.SINGLETON;
                        break;

                    case 2:
                        patternName = DesignPatternConstants.STRATEGY;
                        break;

                    case 3:
                        patternName = DesignPatternConstants.OBSERVER;
                        break;

                    case 4:
                        patternName = DesignPatternConstants.DECORATOR;
                        break;

                    case 5:
                        patternName = DesignPatternConstants.SIMPLE_FACTORY;
                        break;

                    case 6:
                        patternName = DesignPatternConstants.FACTORY_METHOD;
                        break;

                    case 0:
                        continue;

                    default:
                        Console.WriteLine("Enter valid option!!");
                        Console.Clear();
                        continue;
                }

                PrintSummary(patternName);
                RunExample(patternName);
                selectedOption = WaitAndGetUserInput();
            }            
        }

        private static int WaitAndGetUserInput()
        {
            Console.WriteLine("Press any key to go to Main Menu or Enter 0 to Exit!");
            int selectedOption = ReadInputFromConsole();
            Console.Clear();
            return selectedOption;
        }

        private static void RunExample(string patternName)
        {
            Console.WriteLine("");
            Console.WriteLine("Creating instance of pattern and running the example...");
            DesignPatternsFactory.GetInstance(patternName);
            Console.WriteLine("");
            
        }

        private static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to Library of Design Patterns");
            Console.WriteLine("Select Design Pattern from the following:");
            Console.WriteLine("Enter 1 for Singleton Pattern");
            Console.WriteLine("Enter 2 for Strategy Pattern");
            Console.WriteLine("Enter 3 for Observer Pattern");
            Console.WriteLine("Enter 4 for Decorator Pattern");
            Console.WriteLine("Enter 5 for Simple Factory");
            Console.WriteLine("Enter 6 for Factory Method Pattern");
            Console.WriteLine("Enter 0 for Exit");
        }

        private static int ReadInputFromConsole()
        {
            String input = Console.ReadLine();
            int selectedOption = -1;
            try
            {
                selectedOption = Convert.ToInt32(input);
            }
            catch (Exception) { }
            return selectedOption;
        }

        private static void PrintSummary(string patternName)
        {
            DesignPatternSummaryProvider summaryProvider = new DesignPatternSummaryProvider();
            DesignPatternSummary summary = summaryProvider.GetSummary(patternName);
            Console.WriteLine($"Name: {summary.Name}");
            Console.WriteLine($"Definition: {summary.Definition}");
            Console.WriteLine($"Example: {summary.Example}");
        }
    }
}
