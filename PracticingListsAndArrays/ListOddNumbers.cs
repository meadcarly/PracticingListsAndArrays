using System.Collections.Generic;
namespace PracticingListsAndArrays;

public class ListNegativeNumbers
{
    public List<int> GetOddNumbers(int range)
    {
        var oddNumbers = new List<int>();

        for (int i = 1; i < range; i += 2)
        {
            oddNumbers.Add(i);
        }

        return oddNumbers;

        Console.WriteLine($"Odd numbers less than {range} include:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }
    }
}