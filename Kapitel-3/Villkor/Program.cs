// Inloggning för användare
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.Clear();

// Läs in användarnamn
/* Console.Write("Ange användarnamn: ");
string anamn = Console.ReadLine();

// Läs in lösenord
Console.Write("Ange lösenord: ");
string lösenord = Console.ReadLine(); */

// Kolla att lösenordet är rätt
/* if (lösenord == "qwerty")
{
    Console.WriteLine("Lösenordet är rätt! Du blir inloggad.");
}
else
{
    Console.WriteLine("Lösenordet är fel! Vg försök igen...");
} */

// Kolla att användarnamnet är rätt OCH lösenordet är rätt
/* if (anamn == "karre" && lösenord == "qwerty")
{
    Console.WriteLine("Du är inloggad!");
}
else
{
    Console.WriteLine("Användarnamn eller lösenordet stämmer inte!");
} */

Console.Write("Ange en färg (röd, grön , blå): ");
string färg = Console.ReadLine();

if (färg == "röd")
{
    Console.WriteLine("Du valde färgen röd");
}
else if (färg == "grön")
{
    Console.WriteLine("Du valde färgen grön");
}
else if (färg == "blå")
{
    Console.WriteLine("Ok, du valde blå!");
} else
{
    Console.WriteLine($"Du valde färgen {färg}");
}
   

