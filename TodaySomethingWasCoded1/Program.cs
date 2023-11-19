// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("This program will output how many characters a given string input contains, not including spaces.");
Console.WriteLine("Please input a word or series of words: ");

String ?userInput = Console.ReadLine();

int userInputTotalCount = userInput.Count();

int userInputSpaces = userInput.Count(Char.IsWhiteSpace);

userInputTotalCount -= userInputSpaces;

Console.WriteLine(userInputTotalCount.ToString());