// Program för rita ut i konsolen
Console.Clear();

// Starta spelet?
Console.Write("Vill du starta spelet? (j/n) ");
string svar = Console.ReadLine().ToLower();
if (svar != "j")
{
    return;
}

// Skriv ut en hälsning på rad=10, kol=22
Console.SetCursorPosition(22, 10);
Console.Write("Hej världen!");

// Skriv ut "Här är jag" på rad=0, kol=0
Console.SetCursorPosition(0, 0);
Console.Write("Här är jag!");

// Rensa konsolen
Console.Clear();

// Position
int rad = 0;
int kol = 0;

// Dölj konsolmarkören
Console.CursorVisible = false;
Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    // Läs in vad användaren trycker på för tangent
    ConsoleKeyInfo tangent = Console.ReadKey(true); // Pause för att läsa in
    //Console.WriteLine($"Du har tryckt på tangenten: {tangent.Key}");

    // Rensa konsolen
    Console.Clear();

    // Vilken piltangent trycker vi på?
    if (tangent.Key == ConsoleKey.DownArrow)
    {
        rad += 1;
    }
    else if (tangent.Key == ConsoleKey.UpArrow)
    {
        rad -= 1;
    }
    else if (tangent.Key == ConsoleKey.RightArrow)
    {
        kol += 1;
    }
    else if (tangent.Key == ConsoleKey.LeftArrow)
    {
        kol -= 1;
    }

    Console.SetCursorPosition(kol, rad);

    Console.Write("🐸");
}