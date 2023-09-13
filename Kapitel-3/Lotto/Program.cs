// Program för att gissa lottorad
Console.Clear();
int lottorad = 345;

// Be användaren gissa en lottorad
Console.Write("Gissa en lottorad (1-999): ");
string gissningString = Console.ReadLine();
int gissning = int.Parse(gissningString);

// Kollar om det är vinst
if (gissning == lottorad)
{
    Console.WriteLine("Du vann!");
}
else if (gissning > lottorad)
{
    Console.WriteLine("För högt!");
}
else
{
    Console.WriteLine("För lågt!");
}