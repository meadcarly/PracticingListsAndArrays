using System;
using System.Collections.Generic;

namespace PracticingListsAndArrays;

public class ManipulatingLists
{
    public List<int> RemoveEvenAndMultiply(List<int> input)
    {
        input.RemoveAll(x => x % 2 == 0);
        /*var newInput = new List<int> { };
        foreach (var number in input)
        {
            if (number % 2 == 0)
            {
                continue;
            }
            else
            {
                newInput.Add(number);
            }
        }

        foreach (var num in newInput)
        {
            newInput.() = num * 2;
        }

        newInput.Sort();
        foreach (var newNumber in newInput)
        {
            Console.WriteLine(newNumber);
        }

        return newInput;
    }*/
}