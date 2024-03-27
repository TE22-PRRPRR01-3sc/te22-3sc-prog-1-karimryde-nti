/* ***********************************************
 * Den stora påskäggjakten
 * Av: Karim R
 * Datum: 27/3-24
 ************************************************/
// Presentation för användaren
Presentation();

// En variabel för att hålla reda på hur många ägg vi hittat
int antalÄgg = 0;

// Programloopen
while (true)
{
    // Visa en meny med några val
    VisaMeny();
    string val = Console.ReadLine();
    if (val == "1")
    {
        antalÄgg = HittaÄgg(antalÄgg);
    }
    else if (val == "2")
    {
        antalÄgg = ÄtaÄgg(antalÄgg);
    }
    else if (val == "3")
    {
        AntalÄggKvar(antalÄgg);
    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för den här gången!");
        break;
    }
    else
    {
        Console.WriteLine("Vg välj 1-4!");
    }
}



/* ***********************************************
 * ************* M E T O D E R *******************
 ************************************************/
static void Presentation()
{
    Console.Clear();
    Console.WriteLine("Den stora påskäggjakten");
    Console.WriteLine("Lycka till med äggjakten!");
}
static void VisaMeny()
{
    Console.WriteLine("\n1. Hitta ägg");
    Console.WriteLine("2. Äta ägg");
    Console.WriteLine("3. Antal ägg kvar");
    Console.WriteLine("4. Avsluta");
    Console.Write("Ange ditt val: ");
}
static int HittaÄgg(int äggTotal)
{
    // Slumpa ett antal ägg
    int antal = Random.Shared.Next(0, 6);
    Console.WriteLine($"\nDu har hittat {antal} ägg!");

    // Lägg till hittade ägg
    äggTotal += antal;
    Console.WriteLine($"Nu har du {äggTotal} ägg i korgen.");

    return äggTotal;
}
static int ÄtaÄgg(int äggTotal)
{
    // Slumpa ett antal ägg att äta
    int antal = Random.Shared.Next(1, 6);
    Console.WriteLine($"Du äter {antal} ägg");

    if (antal >= 3)
    {
        Console.WriteLine("Nu blev det många ägg. Du får ont i magen");
    }

    // Ta bort uppätna äggen
    äggTotal -= antal;
    Console.WriteLine($"Nu har du {äggTotal} ägg i korgen.");

    return äggTotal;
}
static void AntalÄggKvar(int äggTotal)
{
    Console.WriteLine($"Du har {äggTotal} ägg kvar i korgen!");
}