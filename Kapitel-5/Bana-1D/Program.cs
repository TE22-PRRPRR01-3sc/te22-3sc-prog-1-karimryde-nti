// Labb: rita i konsolen och styra en figur
Console.Clear();
Console.WriteLine("Labb: rita i konsolen och styra en figur");

// Starta spelet?
Console.Write("Vill du starta spelet? (j/n): ");
string svar = Console.ReadLine().ToLower();
if (svar != "j")
{
    return;
}

// För att visa Empjis korrekt
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Skriv ut en vit ruta (statisk)
//Console.WriteLine("⬜😎⬜⬜⬜⬜⬜⬜⬜⬜");

// Skapa en vituell rad med Emojis
//string[] raden = {"⬜", "😎", "⬜", "⬜", "⬜", "⬜", "⬜", "⬜", "⬜", "⬜"};
int[] raden = {0, 1, 0, 0, 0, 0, 0, 0, 0, 0};

// 0 = "⬜"
// 1 = "😎"

// Var är smileyn?
int smileyPos = 1;

// Animationsloopen
while (true)
{
    // Rensa konsolen
    Console.Clear();

    // Rita ut raden, genom att loopa igenom arrayen raden
    foreach (var emoji in raden)
    {
        // Rita ut rätt emoji
        if (emoji == 0)
        {
            Console.Write("⬜");
        }
        else if (emoji == 1)
        {
            Console.Write("😎");
        }
    }
    Console.WriteLine(smileyPos);

    // Flytta smileyn med ett steg
    smileyPos++;

    // Skriv in nya positionen i array raden
    raden[smileyPos] = 1;

    // En fördröjning 500ms = 0,5s
    Thread.Sleep(500);
}