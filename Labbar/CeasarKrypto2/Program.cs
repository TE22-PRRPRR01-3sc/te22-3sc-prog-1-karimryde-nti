/* *************************************************
 * Namn: CeasarKryptoApp
 * Beskrivning: Ett program för Ceasar-kryptering
 * Datum: 2021-09-01
 *********************************************** */
// Presentation
VisaPresentation();

// Programloop som körs tills användaren väljer att avsluta
while (true)
{
    // Visa huvudmeny
    VisaMeny();
    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        Kryptera();
    }
    else if (val == "2")
    {
        Dekryptera();
    }
    else if (val == "3")
    {
        Console.WriteLine("Programmet avslutas.");
        break;
    }
    else
    {
        Console.WriteLine("Fel val, försök igen!");
    }
}




/* **********************************************
 *  Metoder 
 ********************************************** */
/// <summary>
/// Presenterar programmet för användaren
/// </summary>
static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("Programmet för att kryptera meddelande med Ceasar-kryptot");
}

/// <summary>
/// Visar menyn med alla val för användaren
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("1. Kryptera meddelande");
    Console.WriteLine("2. Dekryptera meddelande");
    Console.WriteLine("3. Avsluta");
    Console.Write("Ange ditt val: ");
}

/// <summary>
/// Frågar användaren om meddelande och nyckel
/// Sedan skriver ut det krypterade meddelandet
/// </summary>
static void Kryptera()
{
    // Läs in meddelandet
    Console.Write("Ange meddelande: ");
    string meddelande = Console.ReadLine();

    // Läs in nyckel
    Console.Write("Ange nyckel (1-9): ");
    int nyckel = LäsInHeltal();

    // För varje bokstav i meddelandet
    foreach (var tecken in meddelande)
    {
        // Chiffertecknet
        char chiffer = (char)(tecken + nyckel);

        // Skriv ut chiffret
        Console.Write(chiffer);
    }
    Console.WriteLine();
}

/// <summary>
/// Frågar användaren om meddelande och nyckel
/// Sedan skriver ut det dekrypterade meddelandet
/// </summary>
static void Dekryptera()
{
    // Läs in meddelandet
    Console.Write("Ange krypterade meddelande: ");
    string meddelande = Console.ReadLine();

    // Läs in nyckel
    Console.Write("Ange nyckel (1-9): ");
    int nyckel = LäsInHeltal();

    // För varje bokstav i meddelandet
    foreach (var tecken in meddelande)
    {
        // Chiffertecknet
        char chiffer = (char)(tecken - nyckel);

        // Skriv ut chiffret
        Console.Write(chiffer);
    }
    Console.WriteLine();
}

/// <summary>
/// Säkert sätt att läsa in ett heltal
/// </summary>
/// <returns>heltalet</returns>
static int LäsInHeltal()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int heltal))
        {
            return heltal;
        }
        else
        {
            Console.Write("Ange ett heltal: ");
        }
    }
}