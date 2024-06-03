// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// // string result = new(valueArray);
// string result = String.Join(", ", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(", ");
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] wordPangrams = pangram.Split(" ");

// string resultString = "";

// for (int i = 0; i < wordPangrams.Length; i++)
// {
//     char[] letters = wordPangrams[i].ToCharArray();
//     Array.Reverse(letters);

//     string result = new(letters);
//     resultString += result + " ";
// }

// Console.WriteLine(resultString);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

foreach (string order in orders)
{
    if (order.Length != 4)
    {
        Console.WriteLine(order + "\t- Error");
    }
    else
    {
        Console.WriteLine(order);
    }
}
