Console.Clear();

// en loop som körs så länge användaren skriver in en string som inte kan konverteras till en int.
while (true)
{
    // Skriv in ett tal
    Console.Write("Ange din ålder som tal: ");
    string ålder = Console.ReadLine();
    
    // Kolla om användaren skrivit en tal
    if (int.TryParse(ålder, out int ålderTal) == true)
    {
        Console.WriteLine($"Du skrev ett heltal: {ålderTal}");
        break;
    }
    else
    {
        Console.WriteLine("Du skrev inte ett heltal");
    }
}

// Fråga efter vikten i kg, Se till att användaren matar in ett tal
// Om användaren inte matar in sin vikt som ett tal fråga igen
