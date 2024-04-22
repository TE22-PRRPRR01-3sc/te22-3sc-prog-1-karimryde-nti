Console.Clear();
// Börja med att fråga efter användarens namn
Console.Write("Hej! Vad heter du? ");
string namn = Console.ReadLine();
Console.WriteLine($"Hej {namn}!");

// Skriv ut "Du är bäst!" ifall användarens namn är "Pelle"
if (namn == "Pelle")
{
    Console.WriteLine("Du är bäst!");
}
// Annars skriv ut "Du är inte bäst!"
else
{
    Console.WriteLine($"{namn}, Du är inte bäst!");
}