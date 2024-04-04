using NUnit.Framework;

namespace UniqueElements.Tests;

public class ArrayOperationsTests
{
    [Test]
    public void TestElementsUniqueToFirstArray_WithNullFirstArray_ReturnsEmptyArray()
    {
        int[]? firstArray = null;
        int[] secondArray = [1, 2, 3, 4, 5];
        int[] expectedResult = [];

        int[] result = ArrayOperations.FindElementsUniqueToFirstArray(firstArray, secondArray);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestElementsUniqueToFirstArray_WithNullSecondArray_ReturnsFirstArray()
    {
        int[] firstArray = [1, 2, 3, 4, 5];
        int[]? secondArray = null;
        int[] expectedResult = [1, 2, 3, 4, 5];

        int[] result = ArrayOperations.FindElementsUniqueToFirstArray(firstArray, secondArray);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestElementsUniqueToFirstArray_WithArbitraryValues_ReturnsExpectedElements()
    {
        int[] firstArray = [5, 9, 12, 17, 0, 9, 16, 6, 6, 8];
        int[] secondArray = [2, 17, 9];
        int[] expectedResult = [5, 12, 0, 16, 6, 6, 8];

        var result = ArrayOperations.FindElementsUniqueToFirstArray(firstArray, secondArray);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}