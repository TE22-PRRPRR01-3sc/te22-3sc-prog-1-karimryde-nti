// Program för att räkna ut area
Console.Clear();
Console.WriteLine("Program för att räkna ut area");

// Skapar variabler för längd och bredd
double längd = 0;
double bredd = 0;

// Läs in längden som decimaltal
bool ärDecimaltal = false;
while (ärDecimaltal == false)
{
    Console.Write("Ange längd i m: ");
    string längdString = Console.ReadLine();

    // Konvertera från text till decimaltal
    ärDecimaltal = double.TryParse(längdString, out längd);
    Console.WriteLine($"TryParse säger {ärDecimaltal} och konvertering blir {längd}");
}

// Läs in bredden som decimaltal
while (ärDecimaltal == false)
{
    Console.Write("Ange bredd i m: ");
    string breddString = Console.ReadLine();

    // Konvertera från text till decimaltal
    ärDecimaltal = double.TryParse(breddString, out bredd);
    Console.WriteLine($"TryParse säger {ärDecimaltal} och konvertering blir {bredd}");
}

// Skriv ut arean
Console.WriteLine($"Arean blir {längd * bredd}");