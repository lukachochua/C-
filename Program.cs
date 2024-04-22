Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired!");
}
else if (daysUntilExpiration < 2)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}!");
}
else if (daysUntilExpiration < 6)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}!");
}
else if (daysUntilExpiration < 11)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}


