string[] fraudulentOrderIDs = { "B123", "C456", "A345", "C15", "B177", "G3003", "C235", "B179" };


foreach (var fraudulentOrderID in fraudulentOrderIDs)
{
    if (fraudulentOrderID.StartsWith("B"))
    {
        Console.WriteLine(fraudulentOrderID);
    }
}
