/* ************************************
 * Namn: Enkel klippbok
 * Av: Karim Ryde
 * Datum: 25/3-2024
 **************************************/
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
string filnamn = "meddelanden.txt";
VisaPresentation();

// Programloop
bool avsluta = false;
while (!avsluta)
{
    string val = VisaMenyOchVal();
    switch (val)
    {
        case "1":
            SparaMeddelande(filnamn);
            break;
        case "2":
            LäsaMeddelande(filnamn);
            break;
        case "3":
            avsluta = true;
            Console.WriteLine("Programmet avslutas.");
            break;
        default:
            break;
    }
}
/* ************************************
 * ******* M E T O D E R **************
 **************************************/

/// <summary>
///Berättar om programmet
/// </summary>
static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("Välkommen till klippboken");
    Console.WriteLine("Programmet för att spara ett meddelande som inte försvinner");
}
/// <summary>
/// Visar menyn och läser in användarens val
/// </summary>
/// <returns></returns>
static string VisaMenyOchVal()
{
    Console.WriteLine("\n1. Spara meddelande");
    Console.WriteLine("2. Läsa meddelande");
    Console.WriteLine("3. Avsluta");
    Console.Write("Vad väljer du? ");
    return Console.ReadLine();
}
/// <summary>
/// Läser in meddelandet och sparar i textfil
/// </summary>
/// <param name="filnamn"></param>
static void SparaMeddelande(string filnamn)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();
    File.WriteAllText(filnamn, meddelande);
    Console.WriteLine("Meddelandet sparades");
}
/// <summary>
/// Skriver ut meddelandet från textfilen
/// </summary>
/// <param name="filnamn"></param>
static void LäsaMeddelande(string filnamn)
{
    // Kontrollera att filen finns innan vi läser den
    if (File.Exists(filnamn))
    {
        string meddelande = File.ReadAllText(filnamn);
        Console.WriteLine($"Meddelandet: {meddelande}");
    } else
    {
        Console.WriteLine("Det finns inget meddelande");
    }
}