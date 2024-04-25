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

Console.WriteLine($"Your input value ({role}) has been accepted.");

readLine = Console.ReadLine();

