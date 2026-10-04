// Zad1

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

Console.Write("\nZadanie3\n");

Console.Write("Jak masz na imie: ");
string imie2 = Console.ReadLine();

Console.Write("Jaki jest twój ulubiony kolor: ");
string kolor = Console.ReadLine();

Console.WriteLine($"\nCześć, {imie2}! {kolor} to jest świetny kolor.");

//Zad 4

Console.Write("\nZadanie4\n");

Console.Write("Ile masz lat: ");
string odp = Console.ReadLine();
int wiek2 = int.Parse(odp);

int wiekZaRok = wiek2 + 1;
int wiekZa5Lat = wiek2 + 5;

Console.WriteLine($"Teraz masz: {wiek2} lat, za rok bedziesz mieć: {wiekZaRok} lat a za 5 lat: {wiekZa5Lat} lat.");