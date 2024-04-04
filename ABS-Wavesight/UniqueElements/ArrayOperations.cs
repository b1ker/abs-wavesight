namespace UniqueElements;

public static class ArrayOperations
{
    /// <summary>
    /// Finds the elements that are unique to the first array.
    /// </summary>
    /// <param name="firstArray">The first array.</param>
    /// <param name="secondArray">The second array.</param>
    /// <returns>
    /// Returns an array containing the elements that are present in the first array but not in the second array.
    /// </returns>
    public static int[] FindElementsUniqueToFirstArray(int[]? firstArray, int[]? secondArray)
    {
        if (firstArray == null || firstArray.Length == 0)
        {
            return Array.Empty<int>();
        }

        if (secondArray == null || secondArray.Length == 0)
        {
            return firstArray;
        }

        HashSet<int> secondArraySet = [..secondArray];
        var result = firstArray.Where(element => !secondArraySet.Contains(element)).ToArray();

        return result;
    }
}