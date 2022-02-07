/*
 * Zadatak: Dobivenim brojem X katova na Markovoj zgradi treba
 * ispisati prozore u određenom poretku zadanom u poretku slova
 * 
 */

int X = 0;
string Input = "";
string[] ProzorA = { "....", "....", "....", "...." };
string[] ProzorB = { "####", "####", "####", "####" };
string[] ProzorC = { "....", ".##.", ".##.", "...." };
string[] ProzorD = { "####", "#..#", "#..#", "####" };
Input = Console.ReadLine();
X = int.Parse(Input);
string[] Zgrada = new string[X];

for (int i = 0; i < X; i++)
{
    Zgrada[i] = Console.ReadLine();
}
for (int i = 0; i < X; i++)
{
    for (int j = 0; j < 4; j++)
    {
        foreach (char l in Zgrada[i])
        {
            if (l == 'A') { Console.Write(ProzorA[j]); }
            if (l == 'B') { Console.Write(ProzorB[j]); }
            if (l == 'C') { Console.Write(ProzorC[j]); }
            if (l == 'D') { Console.Write(ProzorD[j]); }
        }
        Console.Write("\n");
    }
}
