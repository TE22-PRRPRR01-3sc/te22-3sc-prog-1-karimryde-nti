// Labyrint, ett konsolsspel
Console.Clear();

// Aktivera UTF8 för att visa Emoji
Console.OutputEncoding = System.Text.Encoding.UTF8;

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
    }
}


