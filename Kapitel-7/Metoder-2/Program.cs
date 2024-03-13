/* *********** HUVUDDEL (MAIN) ********* */
/* ************************************* */
Console.Clear();
//FahrenheitCelsius();
Console.Clear();
//FahrenheitTillCelsius(120);
//FahrenheitTillCelsius(50);

//Teckenrad(6);
//Teckenrad(56);

//TalUppräkning(8);

KastaTärning(5);


/* *********** Metoder ***************** */
/* ************************************* */
/// <summary>
/// Konvertera från Fahrenheit till Celsius
/// </summary>
static void FahrenheitCelsius()
{
    // Läs in temperaturen i Fahrenheit
    Console.Write("Ange temperaturen i Fahrenheit: ");
    int tempFahrenheit = int.Parse(Console.ReadLine());
    int tempCelsius = (tempFahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{tempFahrenheit} Fahrenheit är {tempCelsius} Celsius");
}

static void FahrenheitTillCelsius(int temp)
{
    int tempCelsius = (temp - 32) * 5 / 9;
    Console.WriteLine($"{temp} Fahrenheit är {tempCelsius} Celsius");
}

/// <summary>
/// Metod för att skriva ut bestämt antal #-tecken
/// </summary>
/// <param name="antal"></param>
static void Teckenrad(int antal)
{
    // Upprepa "antal" gånger
    for (int i = 0; i < antal; i++)
    {
        Console.Write("#");
    }
}

/// <summary>
/// Skriv ut en taluppräkning
/// </summary>
/// <param name="tal"></param>
static void TalUppräkning(int tal)
{
    for (int i = 1; i <= tal; i++)
    {
        Console.WriteLine(i);
    }
}

/// <summary>
/// Skriver ut X antal slumptal
/// </summary>
/// <param name="antal"></param>
static void KastaTärning(int antal)
{
    Random slumpgenerator = new Random();

    for (int i = 0; i < antal; i++)
    {
        int slumptal = slumpgenerator.Next(1, 7);
        Console.WriteLine($"Tärningen visar {slumptal}");
    }
}

/// <summary>
/// Vilket tal är störst
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
static void StörstaTal(int tal1, int tal2)
{
    if (tal1 > tal2)
    {
        Console.WriteLine($"{tal1} är störst");
    }
    else
    {
        Console.WriteLine($"{tal2} är störst");
    }
}