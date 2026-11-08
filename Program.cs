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
