// Skapa ett program som ber användaren att mata in ett tal.
// Programmet skall skriva om det inmattade är ett heltal eller decimaltal.
Console.WriteLine("Program som berättar om inmatat är heltal eller decimaltal");

// Inmatning
Console.WriteLine("Ange ett tal: ");
string talString = Console.ReadLine();

// Kolla om det är ett heltal
int heltal = 0;
bool ärHeltal = int.TryParse(talString, out heltal);

if (ärHeltal)
{
    Console.WriteLine("Du har matat in ett heltal!");
}

// Kolla om det är ett decimaltal
int decimaltal = 0;
bool ärDecimaltal = int.TryParse(talString, out decimaltal);

if (ärDecimaltal)
{
    Console.WriteLine("Du har matat in ett decimaltal!");
}