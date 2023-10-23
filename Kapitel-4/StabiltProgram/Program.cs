// Spelet gissa ett tal
Console.Clear();

// Slumpa fram ett tal 1-100
Random tärning = new Random();
int slumptal = tärning.Next(1, 101);

// Inmatningsloop
int gissning = 0;
while (true)
{
    // Be användaren gissa
    Console.Write("Gissa ett tal (1-100): ");
    // Läs in gissningen
    string gissningString = Console.ReadLine();

    // Testa att konvertera till int
    bool lyckadKonvertering = int.TryParse(gissningString, out gissning);
    if (lyckadKonvertering)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste mata in ett tal. Försök igen!");
    }
}

// Koll om gissningen är rätt
if (gissning == slumptal)
{
    Console.WriteLine("Bra gissat!");
}
else
{
    Console.WriteLine("Fel gissat!");
}