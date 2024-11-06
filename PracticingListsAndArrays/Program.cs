using System.Collections.Generic;

namespace PracticingListsAndArrays;

class Program
{
    static void Main(string[] args)
    {
        var carlyFavs = new List<string>();
        carlyFavs.Add("Puppies");
        Console.WriteLine("Carly's favorite things include:");
        foreach (var things in carlyFavs)
        {
            Console.WriteLine(things);
        }

        Console.WriteLine();

        var oddNumbers = new ListNegativeNumbers();
        var range = 67;
        var onlyOddNumbers = oddNumbers.GetOddNumbers(range);
        Console.WriteLine($"The odd numbers in {range}:");
        foreach (var number in onlyOddNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        var manipulatedList = new ManipulatingLists();
        var newList = manipulatedList.RemoveEvenAndMultiply(new List<int> { 5, 8, 3, 7, 10 });
        Console.WriteLine("The new numbers in your list are:");
        foreach (var number in newList)
        {
            Console.WriteLine(number);
        }
    }
}