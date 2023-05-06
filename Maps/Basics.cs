/**
Function that doubles the values of an array of integers
@param inputArray: array of integers
@return array of integers with the values doubled
*/
int[] DoubleValues(int[] inputArray) 
{
    // Create a new array with the same length as the input array
    int[] resultArray = new int[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Double the original value and store it in the new array
        resultArray[i] = inputArray[i] * 2;
    }

    // Return the new array
    return resultArray;
}

/**
Function that converts an array of integers to an array of strings
@param inputArray: array of integers
@return array of strings
*/
string[] IntArrayToStringArray(int[] inputArray) 
{
    // Create a new array with the same length as the input array
    string[] resultArray = new string[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Convert the integer to a string and store it in the new array
        resultArray[i] = inputArray[i].ToString();
    }

    // Return the new array
    return resultArray;
}

/**
Function that fills empty values in an array with a default value
@param inputArray: array of strings
@param defaultValue: string to use as default value
@return array of strings with empty values filled with the default value
*/
string[] FillEmptyValues(string[] inputArray, string defaultValue) 
{
    // Create a new array with the same length as the input array
    string[] resultArray = new string[inputArray.Length];
    
    // Loop through the input array
    for (int i = 0; i < inputArray.Length; i++)
    {
        // If the value is empty, use the default value
        resultArray[i] = inputArray[i] == "" ? defaultValue : inputArray[i];
    }

    // Return the new array
    return resultArray;
}

// Test the functions
DoubleValues(new int[] { 1, 2, 3, 4, 5 });
IntArrayToStringArray(new int[] { 1, 2, 3, 4, 5 });
FillEmptyValues(new string[] { "a", "", "c", "", "e" }, "b");