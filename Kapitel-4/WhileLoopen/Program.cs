// Programmet gissa ett tal
Console.Clear();

// Slumpa fram ett tal
Random tärning = new Random();
int slumptal = tärning.Next(1, 101);     // min=1, max=100

//Console.WriteLine($"Slumptalet är {slumptal}");


// Upprepa med en oändlig loop
while (true)
{
    // Be spelaren gissa ett tal 1-100
    Console.Write("Gissa ett tal 1-100: ");
    string gissningString = Console.ReadLine(); // Läser in en string
    int gissning = int.Parse(gissningString);   // Sen konverterar till heltal

    // Kolla om gissningen är rätt
    if (gissning == slumptal)
    {
        Console.WriteLine("Bravo! Du gissade rätt.");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }

}