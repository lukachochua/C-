try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;

    try
    {
        int result = checked(num1 + num2);
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }

    string str = null;

    try
    {
        int length = str.Length;
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null. You tried to access the Length property of a null string variable." + ex.Message);
    }

    int[] numbers = new int[5];

    try
    {
        numbers[5] = 10; // This line will throw an IndexOutOfRangeException
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range. You tried to access an element outside the array bounds." + ex.Message);
    }

    int num3 = 10;
    int num4 = 0;

    try
    {
        int result2 = num3 / num4; // This line will throw a DivideByZeroException
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
    }
}

catch (Exception ex) // This catch block will catch any other unexpected exceptions
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}

Console.WriteLine("Exiting program.");
