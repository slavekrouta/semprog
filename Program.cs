// See https://aka.ms/new-console-template for more information
void PrintArray(int[] inputData)
{
    for (int i = 0; i < inputData.Length; i++)
    {
        Console.Write($"{inputData[i]}".PadLeft(4));
    }
    Console.WriteLine();
}


Console.Write("Napis pocet prvku k serazeni: ");
int pocet = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[] cisla = new int[pocet];
for(int j = 0; j < pocet; j++)
{
    cisla[j] = random.Next(0,9);
}
for (int x = 0; x < cisla.Length; x++)
{
    for (int i = 1; i < cisla.Length; i++)
    {
        if (cisla[i] < cisla[x] && x < i)
        {
            (cisla[i], cisla[x]) = (cisla[x], cisla[i]);
        }
        PrintArray(cisla);
    }
}

Console.WriteLine();

Console.Write("Vysledek: ");
PrintArray(cisla);

