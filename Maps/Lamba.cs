/**
The map function with lambda expression
@param int[] inputArray The input array
@param Func<int, int> func The function to apply to each value in the array
@return int[] The new array with the function applied to each value
*/
int[] IntegerMap(int[] inputArray, Func<int, int> func)
{
    // Create a new array with the same length as the input array
    int[] resultArray = new int[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Apply the function to the original value and store it in the new array
        resultArray[i] = func(inputArray[i]);
    }

    // Return the new array
    return resultArray;
}

// Test the function
int[] numbers = { 1, 2, 3, 4, 5 };
int[] doubledNumbers = IntegerMap(numbers, x => x * 2);
int[] addedNumbers = IntegerMap(numbers, x => x + 1);
int[] subtractedNumbers = IntegerMap(numbers, x => x - 1);
