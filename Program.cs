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

string pangram = "The quick brown fox jumps over the lazy dog";
string[] wordPangrams = pangram.Split(" ");

string resultString = "";

for (int i = 0; i < wordPangrams.Length; i++)
{
    char[] letters = wordPangrams[i].ToCharArray();
    string? result = "";
    Array.Reverse(letters);

    result = new(letters);
    resultString += result + " ";
}

Console.WriteLine(resultString);
