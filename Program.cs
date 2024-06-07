Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = computerRoll();
        var roll = playerRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    var input = Console.ReadLine()?.Trim().ToUpper();
    return input == "Y";
}

string WinOrLose(int target, int roll)
{
    if (target < roll)
    {
        return "You Win";
    }
    else if (target > roll)
    {
        return "You Lose";
    }
    else
    {
        return "It's a Draw";
    }
}

int playerRoll()
{
    return random.Next(1, 6);
}

int computerRoll()
{
    return random.Next(1, 6);
}