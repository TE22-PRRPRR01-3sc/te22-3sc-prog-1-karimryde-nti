// Repetition
Console.Clear();

// Skapa en string-array med namnen på fem olika spel.
string[] spellista = {"s1", "s2", "s3", "s4", "s5"}; // index = 0, 1, 2, 3, 4

// Skapa en for-loop (eller foreach-loop) som skriver ut namnet på varje spel på en egen rad.
foreach (var spel in spellista)
{
    Console.WriteLine(spel);
}

// Skapa en string-array med namnen på fem av dina klasskamrater.
string[] namnlista = {"Victor", "Ella", "Olle", "Cesar", "Ivar"}; // index = 0, 1, 2, 3, 4

// Skapa en int-array med fem valfria värden mellan 0 och 10.
int[] tallista = {1, 4, 2, 7, 8}; // index = 0, 1, 2, 3, 4

// Skapa en for-loop som skriver ut namnen på kompisarna, en per rad
for (int i = 0; i < namnlista.Length; i++)
{
    Console.WriteLine(namnlista[i]);
}

// Komplettera for-loopen så att den på varje rad skriver ut något liknande "Pelle ger CounterStrike 99 betyget 5".
for (int i = 0; i < namnlista.Length; i++)
{
    Console.WriteLine($"{namnlista[i]} ger {spellista[i]} betyget {tallista[i]}");
}

