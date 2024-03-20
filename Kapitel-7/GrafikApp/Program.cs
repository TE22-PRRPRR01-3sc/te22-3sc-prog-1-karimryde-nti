/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2021-09-01
 *********************************************** */

VisaPresentation();
bool kör = true;

while (kör)
{
    string val = Meny();

    // Hantera användarens val
    switch (val)
    {
        case "1":
            SkrivUtFyrkant();
            break;

        case "2":
            SkrivUtTriangel();
            break;

        case "3":
            SkrivUtGran();
            break;

        // Avsluta programmet
        case "4":
            kör = false;
            break;

        // Ogiltigt val
        default:
            Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
            break;
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */

/// <summary>
/// Presentera programmet för användaren
/// </summary>
static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("Program för att rita konsolgrafik");
    Console.WriteLine("===================================");
    Console.WriteLine();
}

/// <summary>
/// Skriv ut menyn
/// </summary>
static string Meny()
{
    Console.WriteLine("1. Skriv ut fyrkant");
    Console.WriteLine("2. Skriv ut triangel");
    Console.WriteLine("3. Skriv ut gran");
    Console.WriteLine("4. Avsluta");
    Console.Write("\nVälj ett alternativ: ");
    return Console.ReadLine();
}

/// <summary>
/// Läser in heltal på säkert sätt
/// </summary>
/// <returns>Heltalet</returns>
static int LäsInHeltal()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}

static void SkrivUtFyrkant()
{
    int tal = LäsInHeltal();

    // Skriv ut fyrkanten
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void SkrivUtTriangel()
{
    int tal = LäsInHeltal();

    // Skriv ut triangeln
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Skriver ut en gran, frågar anv. om storlek
/// </summary>
static void SkrivUtGran()
{
    int tal = LäsInHeltal();

    // Skriv ut granen
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal - i - 1; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < 2 * i + 1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < tal - 1; j++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("*");
    }
}