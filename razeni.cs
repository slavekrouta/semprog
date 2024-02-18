// Tento program seradi cisla od jenmensiho po nejvetsi

void PrintArray(int[] inputData) // Funkce pro hezke vypsani arraye jakehokoliv typu
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
    cisla[j] = random.Next(0,9); // Vytvori tolik nahodnych cisel, kolik uzivatel napsal na radku 14
}
for (int x = 0; x < cisla.Length; x++) // Cislo se kterym se porovnava
{
    for (int i = 1; i < cisla.Length; i++) // Cislo ktere se porovnava
    {
        if (cisla[i] < cisla[x] && x < i) // Pokud je mensi, prohodi se
        {
            (cisla[i], cisla[x]) = (cisla[x], cisla[i]); // Prohozeni
        }
        PrintArray(cisla);
    }
}

Console.WriteLine();

Console.Write("Vysledek: "); // Vypsani konecneho vysledku (vim ze se vypise uz diky posledni akci ve foru vyse ale to je jedno)
PrintArray(cisla);

