/* string? readResult;

string valueEntered = "";
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Provide an integer value between 5 and 10.");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numericValue);

    if (validNumber == true)
    {
        if (numericValue < 5 || numericValue > 10)
        {
            validNumber = false;
            Console.WriteLine($"You entedered {numericValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }

} while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");

readResult = Console.ReadLine();

bool correctInput = false;
string? readLine;
string role = "";



while (correctInput == false)
{
    Console.WriteLine("Provide a role - Administrator, Manager or User");
    readLine = Console.ReadLine();
    if (readLine != null)
    {
        role = readLine.Trim();
    }

    if (role.ToLower() == "administrator" || role.ToLower() == "user" || role.ToLower() == "manager")
    {
        correctInput = true;
    }
    else
    {
        Console.WriteLine($"The role name you entered, \"{role}\" is not valid.");
    }
}

Console.WriteLine($"Your input value ({role}) has been accepted."); */


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}





