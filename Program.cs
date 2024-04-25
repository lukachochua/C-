string? readResult;

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
