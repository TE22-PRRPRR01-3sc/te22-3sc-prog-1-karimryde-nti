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
        int ruta = labyrint[y, x];

        // Skriv ut det som finns i den positionen
        if (ruta == 1)
        {
            Console.Write("⬛");
        }
        else
        {
            Console.Write("⬜");
        }
    }
}

// Låta användaren styra en figur
Console.CursorVisible = false;

// Var är figuren?
int figurX = 1;
int figurY = 1;

Console.SetCursorPosition(figurX * 2, figurY);
Console.Write("☕");

// Interaktionsloop, där vi lyssnar på tangentnedtryckningar
while (true)
{
    // Läs in tangenten
    ConsoleKeyInfo tangent = Console.ReadKey(true);

    // För att komma ihåg positionen innan vi flyttar
    int gamlaPosX = figurX;
    int gamlaPosY = figurY;

    // Flytta en figur med piltangenterna
    if (tangent.Key == ConsoleKey.RightArrow && labyrint[figurY, figurX + 1] == 0)
    {
        figurX += 1; // Högerpil flyttar +1 
    }
    else if (tangent.Key == ConsoleKey.LeftArrow && labyrint[figurY, figurX - 1] == 0)
    {
        figurX -= 1; // Högerpil flyttar -1 
    }
    else if (tangent.Key == ConsoleKey.UpArrow && labyrint[figurY - 1, figurX] == 0)
    {
        figurY -= 1; // Uppåtpil flyttar -1
    }
    else if (tangent.Key == ConsoleKey.DownArrow && labyrint[figurY + 1, figurX] == 0)
    {
        figurY += 1; // Uppåtpil flyttar +1
    }

    // Återställ den gamla positionen
    Console.SetCursorPosition(gamlaPosX * 2, gamlaPosY);
    Console.Write("⬜");

    // Flytta markören (cursor) och rita ut figur
    Console.SetCursorPosition(figurX * 2, figurY);
    Console.Write("☕");
}
