Console.Clear();

// Fråga användaren efter deras namn och ålder.
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine();
Console.Write("Ange din ålder: ");
string ålder = Console.ReadLine();

// Konvertera användarens ålder från en string till en int.
int ålderTal = int.Parse(ålder);

// Om användaren är under 21 år, skriv ut "Du är för ung för att handla på Systemet!".
if (ålderTal < 21)
{
    Console.WriteLine("Du är för ung för att handla på Systemet!");
}

// Om användaren är äldre än 18 år, skriv ut "Du är gammal nog att ta körkort!".
if (ålderTal >= 18)
{
    Console.WriteLine("Du är gammal nog att ta körkort!");
}