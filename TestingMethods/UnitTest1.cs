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
}