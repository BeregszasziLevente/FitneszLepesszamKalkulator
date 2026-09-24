
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