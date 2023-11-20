// Program för att översätta svenska till morsekod
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Clear();
Console.WriteLine("Program för att översätta svenska till morsekod");

// Två parallella samlingar
string[] alfabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " "};
string[] morsekod = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/" };

// Läs in en mening från användaren
Console.Write("Ange en mening: ");
string mening = Console.ReadLine().ToUpper();

// Loopa igenom meningen bokstav-för-bokstav
foreach (var bokstav in mening)
{
    // Hitta bokstaven och dess position i alfabetet
    // Loopa igenom arrayen 'alfabet' och testa bokstav-för-bokstav
    for (int i = 0; i < alfabet.Length; i++) // i = 0, 1, 2, 3, 4...
    {
        // Jämför bokstaven med inmattade bokstav
        if (alfabet[i] == bokstav.ToString())
        {
            //Console.WriteLine($"Hittade bokstaven {bokstav} på position {i}");
            //Console.WriteLine($"Morsekoden är {morsekod[i]}");
            Console.Write($"{morsekod[i]} ");
        }
    }
}
