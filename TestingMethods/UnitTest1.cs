using System.Runtime.InteropServices;
using PracticingListsAndArrays;
using Xunit;

namespace TestingMethods;

public class Tests
{
    [Theory]
    [InlineData(3, new int[] {1})]
    [InlineData(10, new int[] {1, 3, 5, 7, 9})]
    [InlineData(23, new int[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21})]
    public void ListOddNumbersTest(int range, int [] expected)
    {
        //SetUp
        var oddNum = new ListNegativeNumbers();
        //Act
        var actual = oddNum.GetOddNumbers(range);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] {1, 2, 3, 4, 5}, new int[] {2, 6, 10})]
    [InlineData(new int[]{3, 9, 12, 13}, new int[]{6, 18, 26})]
    [InlineData(new int[]{}, new int[]{})]
    [InlineData(new int[]{0, 2, 6}, new int[] {})]
    [InlineData(new int[]{0, 0, 0}, new int[]{})]
    [InlineData(new int[]{9, 5, 4, 7, 12}, new int[]{10, 14, 18})]

    public void RemoveEvenAndMultiplyTest(int[] input, int[] expected)
    {
        //Arrange
        var manipulatingList = new ManipulatingLists();
        //Act
        var actual = manipulatingList.RemoveEvenAndMultiply(new List<int>(input));
        //Assert
        Assert.Equal(expected, actual);
    }
}