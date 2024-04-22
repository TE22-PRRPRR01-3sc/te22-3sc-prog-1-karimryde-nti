Console.Clear();

// först hämtar in ett användarnamn från användaren
Console.Write("Ange användarnamn: ");
string anamn = Console.ReadLine();

// Fråga efter lösenordet
Console.Write("Ange lösenord: ");
string lösenord = Console.ReadLine();

// "Välkommen" ska skrivas ut enbart om användarnamnet är lika med "noname" och lösenordet är "nopass".
if (anamn == "noname" && lösenord == "nopass")
{
    Console.WriteLine("Välkommen!");
}
// Om någon av dem inte stämmer så ska koden skriva ut "Fel användarnamn eller lösenord!"
else
{
    Console.WriteLine("Fel användarnamn eller lösenord!");
}