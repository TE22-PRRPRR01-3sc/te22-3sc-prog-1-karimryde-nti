/* ************** Bloggappen ****************** */
/* ************** Av: Karim Ryde ************** */

// Presentera programmet för användaren
Console.Clear();
Console.WriteLine("Program för att föra dagbok");

// Skapa en lista för att lagra blogginlägg
List<string> lista = new List<string>();    // Istället för en array

// Programloopen
while (true)
{
    // Visa meny
    VisaMeny();

    // Läs in användarens val
    string val = Console.ReadLine();

    // Hantera menyval
    if (val == "1")
    {
        SkrivInlägg(lista);
    }
    else if (val == "2")
    {
        SkrivUtAllaInlägg(lista);
    }
    else if (val == "3")
    {
        RaderaAllaInlägg(lista);
    }
    else if (val == "4")
    {
        Console.WriteLine("Programmet avslutas!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val, försök igen!");
    }
}








/* ************** Metoder ************** */
static void VisaMeny()
{
    Console.WriteLine("\n1. Skriv blogginlägg");
    Console.WriteLine("2. Skriv ut bloggen");
    Console.WriteLine("3. Radera bloggen");
    Console.WriteLine("4. Avsluta");
    Console.Write("Ange ditt val: ");
}
static void SkrivInlägg(List<string> listan)
{
    // Be användaren mata in inlägg
    Console.Write("Skriv ditt inlägg: ");
    string inlägg = Console.ReadLine();
    
    // Lägg till inlägg i listan
    listan.Add(inlägg);
}
static void SkrivUtAllaInlägg(List<string> listan)
{
    Console.WriteLine("Lista med alla inlägg:");

    // Loopa igenom listan och skriv ut varje
    foreach (var inlägg in listan)
    {
        Console.WriteLine($"> {inlägg}");
    }
}
static void RaderaAllaInlägg(List<string> listan)
{
    listan.Clear();
    Console.WriteLine("Alla inlägg är raderade!");
}