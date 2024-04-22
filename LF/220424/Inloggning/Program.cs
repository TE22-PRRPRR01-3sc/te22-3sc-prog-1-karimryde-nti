Console.Clear();

// Skapa en loop som fortsätter så länge användaren inte har skrivit in rätt lösenord.
while (true)
{
    // Fråga efter lösenord
    Console.Write("Ange lösenord: ");
    string lösenord = Console.ReadLine();

    // Avbryt om rätt lösenord
    if (lösenord == "abc123")
    {
        Console.WriteLine("Välkommen!");
        break;
    }
    // Om användaren skriver in fel lösenord, skriv ut "Fel lösenord!".
    else
    {
        Console.WriteLine("Fel lösenord!");
    }
}