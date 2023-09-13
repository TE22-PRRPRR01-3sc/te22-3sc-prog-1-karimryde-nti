Console.Clear();
Console.WriteLine("Välkommen till guiden felsöka lampa!");

// Ställ den första frågan till användaren
Console.Write("Är lampan inkopplad? (j/n): ");
string svar = Console.ReadLine();

// TODO: Lägg till en if-sats som kontrollerar svaret,
// och ställer nästa fråga eller ger en lösning baserat på svaret
if (svar == "n") {
   Console.WriteLine("Koppla in lampan!");
}
else 
{
   // TODO: Ställ den andra frågan till användaren
   Console.WriteLine("Är glödlampan utbränd? (j/n):");
   string svar2 = Console.ReadLine();

   // TODO: Lägg till en if-sats som kontrollerar svaret på den andra frågan, 
   // och ger en lösning baserat på svaret
   if (svar2 == "j")
   {
      Console.WriteLine("Ersätt glödlampan");
   }
   else
   {
      Console.WriteLine("Köp ny lampa");
   }
}