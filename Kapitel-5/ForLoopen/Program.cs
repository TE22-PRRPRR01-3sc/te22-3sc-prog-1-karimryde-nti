// Ett register för att samla på frukter
Console.Clear();
Console.WriteLine("Ett register för att samla på frukter");

// Skapa en tom array för att lagra alla fruktnamn (100 platser)
string[] fruktlista = new string[100];

// Loopa igenom 0-99
for (int i = 0; i < fruktlista.Length; i++)
{
    // Be användare mata in ett fruktnamn
    Console.Write($"{i}: ange namn på frukt: ");
    fruktlista[i] = Console.ReadLine();

    // En till?
    Console.Write("Vill du mata in en till frukt? (j/n) ");
    if (Console.ReadLine().ToLower() != "j")
    {
        break;
    }
}

// Skriv alla frukter
//for (int i = 0; i < fruktlista.Length; i++)
//{
//    Console.WriteLine($"Frukt nr {i} är {fruktlista[i]}");
//}
//foreach (var frukt in fruktlista)
//{
//    Console.WriteLine($"Frukt: {frukt}");
//}

// Programloop för att användaren skall kunna söka
while (true)
{
    // Fråga till användaren
    Console.Write("Ange sökterm: ");
    string sökterm = Console.ReadLine().ToLower();

    // Loopa igenom arrayen fruktlista
    // Kolla en frukt i taget om det matchar söktermen
    foreach (var frukt in fruktlista)
    {
        // Fritextsökning
        if (frukt != "" && frukt.Contains(sökterm))
        {
            Console.WriteLine($"{frukt} matchar sökterm");
        }
    }
}