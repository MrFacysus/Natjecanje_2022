/*
 * Zadatak: Po veličini ploče X, Y treba odrediti koliko uzastopnih
 * redova možemo ispuniti dominama
 */

int X = 0;
int Rjesenje = 0;
int ProsloRjesenje = 0;
List<string> Ploca = new List<string>();

X = int.Parse(Console.ReadLine());

for (int i = 0; i < X; i++)
{
    Ploca.Add(Console.ReadLine());
}

int[,] Domine = new int[Ploca.First().Count(), X];

for (int i = 0; i < Ploca.First().Length; i++)
{
    for (int j = 0; j < Ploca.Count(); j++)
    {
        Domine[i, j] = 0;
    }
}
for (int i = 0; i < Ploca.First().Length - 1; i++)
{
    for (int j = 0; j < Ploca.Count(); j++)
    {
        if (Ploca[j][i] != Ploca[j][i + 1] && Domine[i, j] == 0 && Domine[i + 1, j] == 0)
        {
            Domine[i, j] = 1;
            Domine[i + 1, j] = 1;
        }
    }
}
for (int i = 0; i < Ploca.First().Length; i++)
{
    for (int j = 0; j < Ploca.Count() - 1; j++)
    {
        if (Ploca[j][i] != Ploca[j + 1][i] && Domine[i, j] == 0 && Domine[i, j + 1] == 0)
        {
            Domine[i, j] = 1;
            Domine[i, j + 1] = 1;
        }
    }
}
for (int i = 0; i < Ploca.Count(); i++)
{
    int temp = 0;
    for (int j = 0; j < Ploca.First().Length; j++)
    {
        if (Domine[j, i] == 1) { temp++; }
    }
    if (temp == Ploca.First().Length)
    {
        ProsloRjesenje++;
        temp = 0;
        if (ProsloRjesenje > Rjesenje)
        {
            Rjesenje = ProsloRjesenje;
        }
    }
    else
    {
        temp = 0;
        ProsloRjesenje = 0;
    }
}
Console.WriteLine(Rjesenje);
