// Grunder i hur man skapar metoder och använder metoder
Console.Clear();

// Skapa en första metod
static void Hej()
{
    Console.WriteLine("Hej på dig!");
}

// Använda den första metoden
Hej();

// Skapa en metod som skriver ut ditt namn
static void MittNamn()
{
    Console.WriteLine("Karim Ryde");
}
MittNamn();

// Skapa en tredje metod som skriver din klass
static void MinKlass()
{
    Console.WriteLine("Min klass är TE22E");
}
MinKlass();

// Skapa en metod som skriver ut en meny
// för en todo applikation
// Tex: Lägg till todo, ta bort todo, visa alla todos
static void SkrivUtMeny()
{
    Console.WriteLine("1. Lägg till todo");
    Console.WriteLine("2. Ta bort todo");
    Console.WriteLine("3. Visa alla todo");
    Console.WriteLine("4. Avsluta");
}
SkrivUtMeny();

// Metod som skriver ut ett meddelande vertikalt 
static void SkrivUtVertikalt()
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();
    foreach (var bokstav in meddelande)
    {
        Console.WriteLine(bokstav);
    }
}
SkrivUtVertikalt();

// En annan variant - ta emot texten
static void SkrivVertikalt(string texten)
{
    foreach (var bokstav in texten)
    {
        Console.WriteLine(bokstav);
    }
}
SkrivVertikalt("Hej");
SkrivVertikalt("Hejsan");
SkrivVertikalt("Snart lunch!");