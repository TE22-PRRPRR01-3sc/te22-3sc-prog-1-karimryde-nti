/* Övning 3: Skapa en meny
Låt användaren välja mellan att köra det första programmet (räknare) eller det andra programmet (flaggor) genom att visa en meny vid start. */

Console.Clear();

// Visa menyn
Console.WriteLine("Välj ett alternativ:");
Console.WriteLine("1. Räkna antal \"ja\"-svar.");
Console.WriteLine("2. Kolla om du är kvalificerad.");
string menyVal = Console.ReadLine();

// Hantera menyval
if (menyVal == "1")
{
    // Program för att räkna antalet ja-svar

    // Vem är du?
    Console.Write("Hej! Vad heter du? ");
    string namn = Console.ReadLine();

    // Fråga 1
    Console.Write("Har du borsta dina tänder idag? (j/n) ");
    string svar = Console.ReadLine().ToLower(); // j -> j, J -> j
    int jaRäknare = 0;
    if (svar == "j")
    {
        jaRäknare += 1; // Lägg till 1
    }

    // Fråga 2
    Console.Write("Har du ätit frukost idag? (j/n) ");
    svar = Console.ReadLine().ToLower(); // j -> j, J -> j
    if (svar == "j")
    {
        jaRäknare += 1; // Lägg till 1
    }

    // Fråga 3
    Console.Write("Har du motionerat idag? (j/n) ");
    svar = Console.ReadLine().ToLower(); // j -> j, J -> j
    if (svar == "j")
    {
        jaRäknare += 1; // Lägg till 1
    }

    // Skriva ut resultatet av enkäten
    //Console.WriteLine($"{namn}, du har svarat ja {jaRäknare} gånger");

    if (jaRäknare == 0 || jaRäknare == 1)
    {
        Console.WriteLine("Det verkar som du kan göra några förbättringar i dina dagliga rutiner.");
    }
    else if (jaRäknare == 2)
    {
        Console.WriteLine("Bra jobbat! Du följer några hälsosamma rutiner.");
    }
    else
    {
        Console.WriteLine("Utmärkt! Du har bra dagliga vanor.");
    }
}
else if (menyVal == "2")
{
    // Program för att avgöra om användaren är kvalificerad

    // Berätta om programmet
    Console.WriteLine("Program för att avgöra om användaren är kvalificerad");

    // Vad heter användaren?
    Console.Write("Ange ditt namn: ");
    string namn = Console.ReadLine();

    // Variabel för att hålla reda på om användaren är kvalificerad
    bool ärKvalificerad = true;     // true/false dvs sant/falskt

    // Fråga 1
    Console.Write("Är du 18 år eller äldre? (j/n) ");
    string svar = Console.ReadLine();
    if (svar != "j")
    {
        ärKvalificerad = false;
    }

    // Fråga 2
    Console.Write("Har du körkort? (j/n) ");
    svar = Console.ReadLine();
    if (svar != "j")
    {
        ärKvalificerad = false;
    }

    // Fråga 3
    Console.Write("Har du någon erfarenhet av programmering? (j/n) ");
    svar = Console.ReadLine();
    if (svar != "j")
    {
        ärKvalificerad = false;
    }

    // Fråga 4
    Console.Write("Har du gymnasieexamen? (j/n) ");
    svar = Console.ReadLine();
    if (svar != "j")
    {
        ärKvalificerad = false;
    }

    // Fråga 5
    Console.Write("Har du erfarenhet av att arbeta i team? (j/n) ");
    svar = Console.ReadLine();
    if (svar != "j")
    {
        ärKvalificerad = false;
    }

    // Ge feedback till användaren
    if (ärKvalificerad)
    {
        Console.WriteLine($"{namn} du är kvalificerad att komma på interview");
    }
    else
    {
        Console.WriteLine($"{namn} du är inte kvalificerad, äterkom nästa år!");
    }
}
else
{
    Console.WriteLine("Fel svar. Välj mellan 1 och 2.");
}