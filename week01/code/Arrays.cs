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
       

    // 1. Create an array with space for the requested number of multiples.
    // 2. Loop through every position in the array.
    // 3. Multiply number by the position plus 1 to get each multiple.
    // 4. Store each multiple in the array.
    // 5. Return the completed array.
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
       // 1. Copy the last "amount" items into a temporary list.
        // 2. Remove those items from the end of the original list.
        // 3. Insert the temporary list at the beginning of the original list.
        int startIndex = data.Count - amount;
        List<int> valuesToMove = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, valuesToMove);
    }
}