string permission = "Manager";
int level = 56;

if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome Super Admin user." : "Welcome, Admin User");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You don not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

