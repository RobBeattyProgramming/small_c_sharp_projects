Console.Clear();

//add TryParse() method once classes get to functions

Dictionary<int, string> operationSelectionList = new Dictionary<int, string>();
operationSelectionList.Add(1, "Addition");
operationSelectionList.Add(2, "Subtraction");
operationSelectionList.Add(3, "Multiplication");
operationSelectionList.Add(4, "Division");

string passwordInput = "";

do {
    Console.Clear();
    if (passwordInput != "")
    {
        Console.WriteLine("Sorry, the password you have entered is incorrect! Please try again\n\n");
    }
    Console.WriteLine("Please enter password to use. \n  Hint: It's a terrible password:");
    passwordInput = Console.ReadLine();
    passwordInput = passwordInput.Trim();
    passwordInput = passwordInput.ToLower();
} while (passwordInput != "password");
Console.Clear();

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
            Console.WriteLine($"Subtraction: {firstValue} + {secondValue}");
            int userAnswer = Int32.Parse(Console.ReadLine());

            if (userAnswer == operationAnswer)
            {
                Console.WriteLine("CORRECT! Input 1 for another addition problem. Input 2 to select a new operation problem");
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
                Console.WriteLine($"nope! Answer is: {operationAnswer}. Input 1 for another addition problem. Input 2 to select a new operation problem");
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
        while (true)
        {
            Console.Clear(); 

            Random rnd = new Random();
            int firstValue = rnd.Next(1,100);
            int secondValue = rnd.Next(1, 100);
            int operationAnswer = firstValue - secondValue;

            // turn into a function later and apply to each section
            Console.WriteLine($"Addition: {firstValue} - {secondValue}");
            int userAnswer = Int32.Parse(Console.ReadLine());

            if (userAnswer == operationAnswer)
            {
                Console.WriteLine("CORRECT! Input 1 for another subtraction problem. Input 2 to select a new operation problem");
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
                Console.WriteLine($"nope! Answer is: {operationAnswer}. Input 1 for another subtraction problem. Input 2 to select a new operation problem");
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
    else if (userSelection == 3)
    {
        while (true)
        {
            Console.Clear(); 

            Random rnd = new Random();
            int firstValue = rnd.Next(1,20);
            int secondValue = rnd.Next(1, 20);
            int operationAnswer = firstValue * secondValue;

            // turn into a function later and apply to each section
            Console.WriteLine($"Multiplication: {firstValue} x {secondValue}");
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
    else if (userSelection == 4)
    {
        while (true)
        {
            Console.Clear(); 

            Random rnd = new Random();
            int firstValue = rnd.Next(1,20);
            int secondValue = rnd.Next(1, 20);
            decimal operationAnswerUnrounded = (decimal)firstValue / secondValue;
            decimal operationAnswer = Math.Round(operationAnswerUnrounded,2);
            

            // turn into a function later and apply to each section
            Console.WriteLine($"Division: {firstValue} / {secondValue}");
            decimal userAnswer = Decimal.Parse(Console.ReadLine());

            if (userAnswer == operationAnswer)
            {
                Console.WriteLine("CORRECT! Input 1 for another division problem. Input 2 to select a new operation problem");
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
                Console.WriteLine($"nope! Answer is: {operationAnswer}. Input 1 for another division problem. Input 2 to select a new operation problem");
                decimal userContinueOption = Int32.Parse(Console.ReadLine());
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
    else if (userSelection == 5)
    {
        break;
    }
    else 
    {
        Console.WriteLine("Please select an option by entering a number between 1 and 4.\n");
        Console.Clear();
    }
}

