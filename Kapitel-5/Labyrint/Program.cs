// Labyrint, ett konsolsspel
Console.Clear();

// Aktivera Unicode för att visa Emoji
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Skapar en labyrint 10 x 10
int[,] labyrint = {
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // y = 0
    {1, 0, 0, 0, 0, 0, 0, 1, 0, 1},
    {1, 1, 1, 1, 0, 0, 0, 1, 0, 1},
    {1, 0, 0, 0, 0, 1, 1, 1, 0, 1},
    {1, 0, 1, 1, 1, 0, 0, 1, 0, 1},
    {1, 0, 1, 0, 0, 1, 0, 1, 0, 1},
    {1, 0, 1, 0, 1, 0, 0, 1, 0, 1},
    {1, 0, 1, 0, 1, 0, 1, 1, 0, 1},
    {1, 0, 0, 0, 1, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
};

// Loopa igenom raderna: y=0 -> y=9
for (int y = 0; y < 10; y++)
{
    // Rita ut varje på raden
    for (int x = 0; x < 10; x++)    // x -> 0-9
    {
        // Flyta markören 
        Console.SetCursorPosition(x * 2, y);

        // Hämta vad som finns i den positionen
        int ruta = labyrint[x, y];

        // Skriv ut det som finns i den positionen
        if (ruta == 1)
        {
            Console.Write("⬛");
        }
        else
        {
            Console.Write("  ");
        }
    }
}

// Låta användaren styra en figur
Console.CursorVisible = false;

// Var är figuren?
int figurX = 1;
int figurY = 1;

// Interaktionsloop, där vi lyssnar på tangentnedtryckningar
while (true)
{
    // Läs in tangenten
    ConsoleKeyInfo tangent = Console.ReadKey(true);

    // Flytta en figur med piltangenterna
    if (tangent.Key == ConsoleKey.RightArrow)
    {
        figurX += 1; // Högerpil flyttar +1 
    }
    else if (tangent.Key == ConsoleKey.LeftArrow)
    {
        figurX -= 1; // Högerpil flyttar -1 
    }
    else if (tangent.Key == ConsoleKey.UpArrow)
    {
        figurY -= 1; // Uppåtpil flyttar -1
    }
    else if (tangent.Key == ConsoleKey.DownArrow)
    {
        figurY += 1; // Uppåtpil flyttar +1
    }

    // Flytta markören (cursor)
    Console.SetCursorPosition(figurX * 2, figurY);

    // Rita ut en figur
    Console.Write("☕");
}
