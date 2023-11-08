// Sökbart register över länder
Console.Clear();
Console.WriteLine("Sökbart register över länder");

/* // Registrera första landet
Console.Write("Ange land 1: ");
string land1 = Console.ReadLine();

// Registrera andra landet
Console.Write("Ange land 2: ");
string land2 = Console.ReadLine();

// Registrera tredje landet
Console.Write("Ange land 3: ");
string land3 = Console.ReadLine();

// Skriv ut alla länder
Console.WriteLine($"Du har registrerat länderna {land1}, {land2}, {land3}"); */

// Skapa en array med plats för 3 länder
string[] länder = new string[3];

// Fyll plats 1 i arrayen "länder"
länder[0] = "Sverige";
länder[1] = "Norge";
länder[2] = "Finland";

// Skapa en array över 4 favoritgodisar och fyll arrayen
string[] godisar = new string[4];
godisar[0] = "Kola";
godisar[1] = "Glass";
godisar[2] = "Choklad";
godisar[3] = "Bulle";

// Skapa en array och fyll den direkt
string[] landlista = {"Tyskland", "Frankrike", "Danmark", "Island"};

// Skapa en array på 4 favvomaträtter
string[] maträtter = {"Pizza", "Hamburgare", "Sushi", "Kebab"};

// Skapa en array på ålder på dina syskon
int[] ålderlista = {5, 12, 17, 23};

// Skriv ut alla maträtter, en per rad
Console.WriteLine($"En av mina favorit maträtt är {maträtter[0]}");
Console.WriteLine($"En av mina favorit maträtt är {maträtter[1]}");
Console.WriteLine($"En av mina favorit maträtt är {maträtter[2]}");
Console.WriteLine($"En av mina favorit maträtt är {maträtter[3]}");

// Loopa igenom arrayen syskon med foreach-loopen
// Och skriv ut varje ålder
foreach (var ålder in ålderlista)
{
    Console.WriteLine($"Ett av mina syskon har åldern {ålder}");
}

// Skriv ut varje favvo godis
foreach (var godis in godisar)
{
    Console.WriteLine($"Ett av mina favvogodisar är {godis}");
}