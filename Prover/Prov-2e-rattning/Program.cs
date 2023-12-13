// Skapa ett program för skapa och hantera en veckomeny.

Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine(
    "Program för att skapa en veckomeny" +
    "==================================" +
    "Det finns 2 arrayer, en för veckodagar och en för maträtter:" +
    "- 5 veckodagar finns redan i arrayen för veckodagar" +
    "- Arrayen för maträtter är tom");

// Det finns 2 arrayer, en för veckodagar och en för maträtter
string[] veckodagar = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag" };
string[] maträtter = new string[5];

// Fylla veckomenyn
Console.WriteLine("Ange maträtterna för veckan:");


//Console.Write("2 Tisdag: ");
//maträtter[1] = Console.ReadLine();
//Console.Write("3 Onsdag: ");
//maträtter[2] = Console.ReadLine();
//Console.Write("4 Torsdag: ");
//maträtter[3] = Console.ReadLine();
//Console.Write("5 Fredag: ");
//maträtter[4] = Console.ReadLine();

for (int i = 0; i < 5; i++) // 0, 1, 2, 3, 4
{
    Console.Write($"{i + 1} {veckodagar[i]}: ");
    maträtter[i] = Console.ReadLine();
}

Console.WriteLine("Blanda ihop en meny");
Console.WriteLine("===================");

Console.Write("Del 1. Vill du byta ut en maträtt? (j/n) ");
string svar = Console.ReadLine();
if (svar == "j")
{
    Console.Write("Vilken dag vill du byta maträtt på? (1-5) ");
    int dag = 0;
    bool ärHeltal = false;
    while (true)
    {
        // Fråga användaren om ett tal
        Console.Write("Ange en dag (1-5)? ");
        string input = Console.ReadLine();

        // Försök omvandla strängen till ett heltal
        ärHeltal = int.TryParse(input, out dag);

        // Om omvandlingen misslyckades, skriv ut ett felmeddelande
        if (!ärHeltal)
        {
            Console.WriteLine("Svara med heltal, tack!");
        }
        // Om omvandlingen lyckades, avsluta loopen
        else
        {
            break;
        }
    }

    Console.Write($"Ange ny maträtt för {veckodagar[dag - 1]}: ");
    string nyMaträtt = Console.ReadLine();

    // Spara i arrayen
    maträtter[dag - 1] = nyMaträtt;
}

Console.Write("Del 2. Vill du byta plats på två dagar? (j/n) ");
svar = Console.ReadLine();
if (svar == "j")
{
    Console.Write("Vilken dag vill du byta plats på? (1-5) ");
    int dag1 = int.Parse(Console.ReadLine());
    Console.Write("Vilken dag vill du byta plats med? (1-5) ");
    int dag2 = int.Parse(Console.ReadLine());

    string temp = maträtter[dag1 - 1];
    maträtter[dag1 - 1] = maträtter[dag2 - 1];
    maträtter[dag2 - 1] = temp;
}

Console.WriteLine("Veckomeny");
Console.WriteLine("==========");
for (int i = 0; i < 5; i++) // 0, 1, 2, 3, 4
{
    Console.Write($"{i + 1} {veckodagar[i]}: {maträtter[i]}");
}