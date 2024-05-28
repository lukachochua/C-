string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal result = 0;

decimal holder = 0;

string resultString = "";

for (int i = 0; i < values.Length; i++)
{
    if (decimal.TryParse(values[i], out result))
    {
        holder += result;
    }
    else
    {
        resultString += values[i];
    }

}
Console.WriteLine("Message: " + resultString);
Console.WriteLine("Total: " + holder);
