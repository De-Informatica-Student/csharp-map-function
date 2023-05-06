/**
The complete map function with lambda expression and generic types
@param T[] inputArray The input array
@param Func<T, U> func The function to apply to each value in the array
@return U[] The new array with the function applied to each value
*/
U[] Map<T, U>(T[] inputArray, Func<T, U> func)
{
    // Create a new array with the same length as the input array
    U[] resultArray = new U[inputArray.Length];
    
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
int[] doubledNumbers = Map(numbers, x => x * 2);
string[] stringNumbers = Map(numbers, x => x.ToString());
bool[] isEvenNumbers = Map(numbers, x => x % 2 == 0);