Random rnd = new Random();

int attack = rnd.Next(1, 11);

int Hero = 10;
int Monster = 10;



do
{
    // Hero Attacks
    attack = rnd.Next(1, 11);
    Monster -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {Monster} health.");

    if (Monster <= 0) break;

    // Monster Attacks
    attack = rnd.Next(1, 11);
    Hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {Hero} health.");
    if (Hero <= 0) break;
} while (Hero >= 0 || Monster >= 0);

if (Monster <= 0)
    Console.WriteLine("Hero Wins");
else if (Hero <= 0)
    Console.WriteLine("Monster Wins");
