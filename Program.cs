/*
// Zad1

using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("\nZadanie1\nCześć");
Console.WriteLine("Wiktoria");
Console.Write("Wydział ");
Console.Write("Informatyki");
Console.WriteLine("\nPowtórzyć podstawy C#");

// Zad2

string imie = "Wiktoria";
int wiek = 20;
string gra = "The Sims 4";

Console.WriteLine("\nZadanie 2");
Console.WriteLine("=====WIZYTÓWKA=====");
Console.WriteLine($"| Imie: {imie}  |");
Console.WriteLine($"| Wiek: {wiek}        |");
Console.WriteLine($"| Gra: {gra} |");
Console.WriteLine("===================");

//zad3 

Console.Write("\nZadanie 3\n");

Console.Write("Jak masz na imie: ");
string imie2 = Console.ReadLine();

Console.Write("Jaki jest twój ulubiony kolor: ");
string kolor = Console.ReadLine();

Console.WriteLine($"\nCześć, {imie2}! {kolor} to jest świetny kolor.");

//Zad 4

Console.Write("\nZadanie 4\n");

Console.Write("Ile masz lat: ");
string odp = Console.ReadLine();
int wiek2 = int.Parse(odp);

int wiekZaRok = wiek2 + 1;
int wiekZa5Lat = wiek2 + 5;

Console.WriteLine($"Teraz masz: {wiek2} lat, za rok bedziesz mieć: {wiekZaRok} lat a za 5 lat: {wiekZa5Lat} lat.");

*/
//Zad9

Console.Write("\nZadanie 9\n");

Console.Write("Podaj czas w sekundach: ");
string odp2 = Console.ReadLine();
int czas = int.Parse(odp2);

int minuty = czas / 60;
int sekundy = czas % 60;

Console.WriteLine($"{czas} sekund to {minuty} minuty i {sekundy} sekundy.");

//zad 10

Console.Write("\nZadanie 10\n");

Console.Write("Ilu bohaterow macie w druzynie: ");
string bohaterzy = Console.ReadLine();
int lbBohaterzy = int.Parse(bohaterzy);

Console.Write("A ile zdobyliście monet: ");
string monety = Console.ReadLine();
int lbMonety = int.Parse(monety);

int podzial = lbMonety / lbBohaterzy;
int pula = lbMonety % lbBohaterzy;

Console.WriteLine($"Aby było równo każdy bohater dostanie {podzial} monet. W puli zostanie {pula} monety.");

//zad 11

Console.Write("\nZadanie 11\n");

Console.Write("Podaj wartość podstawowych obrażeń broni: ");
string obr = Console.ReadLine();
int wartObr = int.Parse(obr);

Console.Write("Podaj premię do siły: ");
string premia = Console.ReadLine();
int wartPremii = int.Parse(premia);

int zwykly = wartObr + wartPremii;
Console.WriteLine($"Wartość twojego zwykłego ataku to: {zwykly}");

int specjalny = 2 * zwykly;
Console.WriteLine($"Wartość twojego ataku specjalnego to: {specjalny}");

int ultraspecjalny = (3 * zwykly) + specjalny;
Console.WriteLine($"Twój super specjalny atak wynosi: {ultraspecjalny}");

Console.WriteLine("\nRaport obliczeń:");
Console.WriteLine("Aby obliczyc zwykły atak dodałam do siebie \nwartość podstawowych obrażeń broni i premię do siły");
Console.WriteLine("Aby obliczyć specjlany atak pomnożyłam zwykły atak * 2");
Console.WriteLine("Aby obliczyć super specjalny atak najpierw pomnożyłam zwykły * 3 \nmając to w nawiasie. Do tego dodałam jeden specjalny");

