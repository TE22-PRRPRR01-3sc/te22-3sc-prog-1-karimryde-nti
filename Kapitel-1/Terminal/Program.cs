// Startar med en hälsning
Console.Clear();
Console.WriteLine("Hej, världen!");

// Vem är du?
Console.WriteLine("Vad heter du? ");

// Läs in text
string namn = Console.ReadLine();

// Skriv ut en hälsning
Console.WriteLine("Trevligt att se dig " + namn);    // cw

// Vart bor du?
Console.Write("Var bor du? ");
string adress = Console.ReadLine();

Console.WriteLine("Ok, du bor på " + adress);

// Vad gör du på fritiden?
Console.Write("Vad gör du på fritiden?");
string fritid = Console.ReadLine();

// Sammanfattning
Console.WriteLine(namn + " du bor i " + adress + ", och på din fritid " + fritid);