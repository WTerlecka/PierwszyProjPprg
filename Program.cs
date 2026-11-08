//8.11.2026

//Zadanie 1
Console.WriteLine("Zadanie 1");
Console.WriteLine("Pierwszy sposób (for): ");
for (int lb = 1; lb <= 10; lb++)
{
    Console.Write($"{lb} ");
}

Console.WriteLine("\nDrugi sposób (while):");
int lb2 = 1;
while (lb2 <= 10)
{
    Console.Write($"{lb2} ");
    lb2++;
}

Console.WriteLine("\nTrzeci sposób( do...while...):");
int lb3 = 1;
do
{
    Console.Write($"{lb3} ");
    lb3++;
}
while (lb3 <= 10);
Console.WriteLine("\nMalejąco: ");
for(int malejaco = 10; malejaco > 0; malejaco--)
{
    Console.Write($"{malejaco} ");
}
Console.WriteLine("\nParzyste: ");
for(int parzyste = 0; parzyste <= 20; parzyste += 2)
{
    Console.Write($"{parzyste} ");
}
Console.WriteLine("\nStart!");

//Zadanie 2

Console.WriteLine("Zadanie 2");

Console.Write("Ile dni trwała wyprawa(1-7): ");
int dniWyprawy = int.Parse(Console.ReadLine());
int sumaZłota = 0;
int udaneDni = 0;
for (int i = 1; i <= dniWyprawy; i++)
{
    Console.Write($"Złoto w dniu {i}: ");
    int złoto = int.Parse(Console.ReadLine());
    sumaZłota += złoto;

    if (złoto > 10)
    {
        udaneDni ++;
    }
}
Console.WriteLine($"\nŁącznie znaleziono: {sumaZłota} sztuk złota");
Console.WriteLine($"Dni z wynikiem powyżej 10: {udaneDni}");

//Zadanie 3

Console.WriteLine("\nZadanie 3");


//zadanie 4

Console.WriteLine("\nZadanie 4");
int liczbaTur;

while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    bool czyLiczba = int.TryParse(Console.ReadLine(), out liczbaTur);

    if (!czyLiczba)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (liczbaTur < 1 || liczbaTur > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam grę na {liczbaTur} tur.");

for (int i = 1; i <= liczbaTur; i++)
{
    Console.Write($"{i} ");
}