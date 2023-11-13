// Arbeta med element i array
Console.Clear();

// Vi skapar en array för fruktnamn (string)
string[] frukter = {"äpple", "banan", "kiwi"};

//Console.WriteLine(frukter[0]);

// Vi skapar en array för namn med 5 platser
string[] namnlista = new string[5];

// Fylla arrayen
namnlista[0] = "Kalle";
namnlista[1] = "Lisa";
namnlista[2] = "Pelle";

// Skriv ut alla frukter
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Fråga användaren om en position i arrayen frukt: 0, 1, 2
// Be användaren mata i namnet på en ny frukt
// Byt ut den nya frukten i arrayen
Console.Write("Ange en position i arrayen (0, 1, 2): ");
int position = int.Parse(Console.ReadLine());
Console.Write("Ange en ny frukt: ");
string nyFrukt = Console.ReadLine();

// Byter ut frukten på valda position
frukter[position] = nyFrukt;

// Skriv ut igen den ändrade arrayen
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

