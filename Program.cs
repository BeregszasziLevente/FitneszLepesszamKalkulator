
List<int> lepes = new List<int> ();

Console.WriteLine("=== Heti Lépésszám Rögzítése ===");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{i+1}. nap lépésszám: ");
    lepes.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("\nAdatok feldolgozása...");
Console.WriteLine("========================================");
Console.WriteLine("Rögzített napi lépésszámok:");

for (int i=0; i < 5; i++)
{
    Console.WriteLine($"\t- {i + 1}. nap lépésszáma: {lepes[i]}");
}

Console.WriteLine("----------------------------------------");

int ossz=0;

for (int i = 0;i < 5;i++)
{
    ossz += lepes[i];
}

double atlag = ossz / 5.0;

string statusz;

if (atlag >= 10000) statusz = "Kiváló forma, teljesítetted a célt!";
else if (atlag >= 7000) statusz = "Átlagos aktivitás, jó úton jársz.";
else statusz = "Kevés mozgás, több aktivitás szükséges!";

Console.WriteLine($"Összes lépésszám: {ossz} lépés");
Console.WriteLine($"Napi átlagos lépésszám: {atlag:F0} lépés");
Console.WriteLine($"Heti értékelés: {statusz}");

Console.WriteLine("========================================");

