/* ********************************* */
/*           Main                    */
/* ********************************* */
Console.Clear();
TalMellan(5, 10);
TalMellan(10, 5);

Console.Clear();
Fibonacci(100);

Console.Clear();
Polaritet(-5);
Polaritet(0);
Polaritet(10);

Console.Clear();
Längst("Hej", "Hejdå");

/* ********************************* */
/*         Metoderna                 */
/* ********************************* */
/* Uppgift 8
Skapa en metod som tar emot två heltal och skriver ut alla tal mellan dem.
Tips: Använd en for-loop. */

static void TalMellan(int tal1, int tal2)
{
    for (int i = tal1 + 1; i < tal2; i++)
    {
        Console.WriteLine(i);
    }
}

/* Uppgift 9
Skapa en metod som tar emot ett heltal och skriver ut Fibonacci-talen upp till det givna talet.
Fibonacci-talen är en serie där varje tal är summan av de två föregående talen. Serien börjar med 0 och 1. */
static void Fibonacci(int max)
{
    int tal1 = 0;
    int tal2 = 1;
    Console.Write("0 1 ");
    while (true)
    {
        // Summera två föregående
        int summa = tal1 + tal2;
        
        // Avbryt om större än maxgränsen
        if (summa > max)
        {
            break;
        }

        // Skriv ut summan
        Console.Write(summa + " ");

        // Flytta fram
        tal1 = tal2;
        tal2 = summa;
    }
}

/* 
Uppgift 10
Skapa en metod som tar emot ett heltal och skriver ut om talet är positivt, negativt eller noll.
Tips: Använd if-satser för att kontrollera talets värde. */
static void Polaritet(int tal)
{
    if (tal > 0)
    {
        Console.WriteLine($"{tal} är positivt");
    }
    else if (tal < 0)
    {
        Console.WriteLine($"{tal} är negativt");
    }
    else
    {
        Console.WriteLine($"{tal} är noll");
    }
}

/* Uppgift 11
Skapa en metod som tar emot två strängar och skriver ut den längre av dem.
Tips: Använd .Length för att få reda på strängarnas längd. */
static void Längst(string sträng1, string sträng2)
{
    if (sträng1.Length > sträng2.Length)
    {
        Console.WriteLine(sträng1);
    }
    else if (sträng1.Length < sträng2.Length)
    {
        Console.WriteLine(sträng2);
    }
    else
    {
        Console.WriteLine("Strängarna är lika långa");
    }
}