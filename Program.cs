string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:N}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"{currentProduct.PadRight(18)}{currentReturn:p}\t{currentProfit:C}\n{newProduct.PadRight(18)}{newReturn:C}\t{newProfit:N}";

// Your logic here

Console.WriteLine($"{comparisonMessage}");