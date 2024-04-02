// See https://aka.ms/new-console-template for more information
string greeting = @"Welcome to Thrown for a Loop
Your one stop shop for used sporting equipment";
Console.WriteLine(greeting);
Console.WriteLine("Please enter a product name: ");

string response = Console.ReadLine().Trim();
while (string.IsNullOrEmpty(response))
{
    Console.WriteLine("You didn't choose anything, try again!");
    response = Console.ReadLine().Trim();
}

Console.WriteLine(@$"You chose: {response}
Thank you for your input");
