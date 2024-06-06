string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";


void displayEmails(string first, string second, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + second;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    displayEmails(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    displayEmails(corporate[i, 0], corporate[i, 1], externalDomain);
}
