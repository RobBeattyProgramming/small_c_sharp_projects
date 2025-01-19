﻿Console.Clear();

Dictionary<int, string> operationSelectionList = new Dictionary<int, string>();
operationSelectionList.Add(1, "Addition");
operationSelectionList.Add(2, "Subtraction");
operationSelectionList.Add(3, "Multiplication");
operationSelectionList.Add(4, "Division");

while (true)
{
    Console.WriteLine("Which math operation would you like to practice? Enter 5 to end program.\n");
    
    for (int i = 1; i < 5; i++)
    {
        Console.WriteLine($"{i}: {operationSelectionList[i]}");
    }
    Console.WriteLine("\nPlease select by inputing a number from 1-4:\n");
    int userSelection = Int32.Parse(Console.ReadLine());

    if (userSelection == 1)
    {
        while (true)
        {
            Console.Clear(); 

            Random rnd = new Random();
            int firstValue = rnd.Next(1,100);
            int secondValue = rnd.Next(1, 100);
            int operationAnswer = firstValue + secondValue;

            // turn into a function later and apply to each section
            Console.WriteLine($"Addition: {firstValue} + {secondValue}");
            int userAnswer = Int32.Parse(Console.ReadLine());

            if (userAnswer == operationAnswer)
            {
                Console.WriteLine("CORRECT! Input 1 for another multiplication problem. Input 2 to select a new operation problem");
                int userContinueOption = Int32.Parse(Console.ReadLine());
                if (userContinueOption == 1)
                {
                    continue;
                }
                else if (userContinueOption == 2)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine($"nope! Answer is: {operationAnswer}. Input 1 for another multiplication problem. Input 2 to select a new operation problem");
                int userContinueOption = Int32.Parse(Console.ReadLine());
                if (userContinueOption == 1)
                {
                    continue;
                }
                else if (userContinueOption == 2)
                {
                    break;
                }
            }


        }
    }
    else if (userSelection == 2)
    {
        Console.WriteLine("2");
    }
    else if (userSelection == 3)
    {
        Console.WriteLine("3");
    }
    else if (userSelection == 4)
    {
        Console.WriteLine("4");
    }
    else if (userSelection == 5)
    {
        Console.WriteLine("5");
        break;
    }
    else 
    {
        Console.WriteLine("Please select an option by entering a number between 1 and 4.\n");
        Console.Clear();
    }
}

