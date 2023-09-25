// Program för att räkna antalet ja-svar
Console.Clear();

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