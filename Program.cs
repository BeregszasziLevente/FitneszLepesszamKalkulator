
List<int> lepes = new List<int> ();

for (int i = 0; i < 5; i++)
{
    Console.Write($"{i+1}. nap lépésszám: ");
    lepes.Add(int.Parse(Console.ReadLine()));
}

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

