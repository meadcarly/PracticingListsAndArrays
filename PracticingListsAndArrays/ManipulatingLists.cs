using System;
using System.Collections.Generic;

namespace PracticingListsAndArrays;

public class ManipulatingLists
{
    public List<int> RemoveEvenAndMultiply(List<int> input)
    {
        input.RemoveAll(x => x % 2 == 0);

        for (int i = 0; i < input.Count; i++)
        {
            input[i] *= 2;
        }
        
        input.Sort();

        return input;
    }
}