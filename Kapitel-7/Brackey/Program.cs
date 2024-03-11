/* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
/* ********** Main *************** */
/* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

// Träna på metoder
Console.Clear();
MeetAlien();
Console.WriteLine("-----------------");
MeetAlien();
Console.Clear();
Multiply(3, 5);
Multiply(33, 55);

Console.Clear();
ÄrJämntEllerUdda(567);
ÄrJämntEllerUdda(66656);

Console.Clear();
CelsiusTillFahrenheit(32);

/* ******************************* */
/* ********** Metoder ************ */
/* ******************************* */

/// <summary>
/// Skriver ut hälsning från en utomjording
/// </summary>
static void MeetAlien()
{
    Random numberGen = new Random();
    string name = $"X-{numberGen.Next(10, 9999)}";
    int age = numberGen.Next(10, 500);
    Console.WriteLine($"Hi, I'm {name}.");
    Console.WriteLine($"I'm {age} years old.");
    Console.WriteLine("Oh, by the way I'm an alien.");
}

/// <summary>
/// Multiplicerar två tal och skriver ut resultat
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
static void Multiply(int tal1, int tal2)
{
    int resultat = tal1 * tal2;
    Console.WriteLine($"{tal1} * {tal2} är lika med {resultat}");
}

/// <summary>
/// Metod som tar emot ett heltal och skriver ut om talet är jämnt eller udda.
/// </summary>
/// <param name="tal"></param>
static void ÄrJämntEllerUdda(int tal)
{
    if (tal % 2 == 0)
    {
        Console.WriteLine($"{tal} är jämnt");
    }
    else
    {
        Console.WriteLine($"{tal} är udda");
    }
}

/// <summary>
/// metod som omvandlar temperatur från Celsius till Fahrenheit
/// </summary>
/// <param name="celsius"></param>
static void CelsiusTillFahrenheit(int celsius)
{
    int fahrenheit = celsius * 9/5 + 32;
    Console.WriteLine($"{celsius} grader Celsius motsvarar {fahrenheit} grader Fahrenheit");
}