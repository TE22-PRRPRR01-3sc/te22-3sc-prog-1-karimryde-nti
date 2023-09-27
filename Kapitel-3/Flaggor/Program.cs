// Program för att avgöra om användaren är kvalificerad
Console.Clear();

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