// Program för att registrera personinfo

Console.Clear();

// Läs in namn
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine();

// Läs in klass
Console.Write("Ange din klass: ");
string klass = Console.ReadLine();

// Skriv en sammanfattning
//Console.WriteLine(namn + " du går i klass " + klass);
Console.WriteLine($"{namn} du går i klass {klass}");

// Läs in ålder
Console.Write("Ange din ålder: ");
string ålderString = Console.ReadLine();
int ålder = int.Parse(ålderString);

// Räkna ut ålder vid examen
int ålderVidExamen = ålder + 1;

// Skriv ut resultatet
Console.WriteLine($"När du {namn} tar examen är du {ålderVidExamen} år");

// Läs in längd i meter
Console.Write("Ange din längd (m): ");
string längdString = Console.ReadLine();
double längd = double.Parse(längdString);

// Konvertera till cm
double längdCm = längd * 100;

// Skriv ut resultat i cm
Console.WriteLine($"{namn} du är {ålder} år och {längdCm} cm lång!");