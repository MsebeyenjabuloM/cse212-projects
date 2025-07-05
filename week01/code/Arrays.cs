public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // My Plan:
        // 1. Create a new array of doubles with the size of 'length'.
        // 2. Loop from 0 to length - 1.
        // 3. In each step of the loop, multiply the index + 1 by the number.
        // 4. Store the result in the array at that index.
        // 5. After the loop, return the array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // My Plan:
        // 1. Figure out the part of the list we want to move to the front.
        //    This will be the last 'amount' elements from the list.
        // 2. Use GetRange to get the last 'amount' elements.
        // 3. Use RemoveRange to take those elements out of the end of the list.
        // 4. Use InsertRange to add them back to the front of the list.
        // 5. After doing this, the list will be rotated to the right.

        List<int> endPart = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, endPart);
    }
}
