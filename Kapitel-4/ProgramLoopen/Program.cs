// Program för att omvandla text
Console.Clear();
Console.WriteLine("Program för att omvandla text");

// Deklarera en variabel för att lagra användarens val
string val = "";

// Programloop som snurrar tills användaren väljer att avsluta programmet
while (true)
{
    // Menyn som visas för användaren
    Console.WriteLine("\nVälj ett av följande alternativ:");
    Console.WriteLine("1 Omvandla text till versaler");     // Stora bokstäver
    Console.WriteLine("2 Omvandla text till gemena");       // Små bokstäver
    Console.WriteLine("3 Avsluta programmet");

    // Läs in användarens val
    Console.Write("Ditt val: ");
    val = Console.ReadLine();
    
    // Hantera användarens val
    if (val == "1")
    {
        Console.Write("Skriv in en text: ");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler: {text}");
    }
    else if (val == "2")
    {
        Console.Write("Skriv in en text: ");
        string text = Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener: {text}");
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen!");
    }
}