Console.Clear();

Dictionary<int, string> operationSelectionList = new Dictionary<int, string>();
operationSelectionList.Add(1, "Addition");
operationSelectionList.Add(2, "Subtraction");
operationSelectionList.Add(3, "Multiplication");
operationSelectionList.Add(4, "Division");

Console.WriteLine("Which math operation would you like to practice?\n");
for(int i = 1; i < 5; i++)
{
    Console.WriteLine($"{i}: {operationSelectionList[i]}");
}
Console.WriteLine("\nPlease select by inputing a number from 1-4");
int userSelection = Int32.Parse(Console.ReadLine());
