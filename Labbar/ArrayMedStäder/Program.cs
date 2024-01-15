using System.Runtime.Intrinsics.Arm;

Console.Clear();

// Skapa en tom string-lista som heter städer med 10 platser.
string[] städer = new string[10];

// Skapa en loop där du varje gång loopen körs hämtar en string från användaren med Console.ReadLine().
// Svar 1: läs in alla 10 städer
for (int i = 0; i < städer.Length; i++)
{
    Console.Write("Ange en stad: ");
    städer[i] = Console.ReadLine();
}

// Svar 2: låt användaren bestämma hur många han vill mata in
for (int i = 0; i < städer.Length; i++)
{
    Console.Write("Ange en stad: ");
    städer[i] = Console.ReadLine();

    Console.Write("Vill du mata in en till? (j/n) ");
    if (Console.ReadLine() != "j")
    {
        break;
    }
}

// Svar 3: låt användaren bestämma i förväg antal namn att mata in
Console.Write("Hur många namn vill du mata in? ");
int antal = int.Parse(Console.ReadLine());
for (int i = 0; i < antal; i++)
{
    Console.Write("Ange en stad: ");
    städer[i] = Console.ReadLine();
}
