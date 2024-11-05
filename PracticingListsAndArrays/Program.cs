using System.Collections.Generic;

namespace PracticingListsAndArrays;

class Program
{
    static void Main(string[] args)
    {
        var carlyFavs = new List<string>();
        carlyFavs.Add("Puppies");
        foreach (var things in carlyFavs)
        {
            Console.WriteLine(things);
        }

        var oddNumbers = new ListNegativeNumbers();
        oddNumbers.GetOddNumbers(67);
    }
}