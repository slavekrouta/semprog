using System;

class Program
{
	static void Main()
	{
    string input = Console.ReadLine();
		int[] cisla = new int[input.ToCharArray().Length];
		for (int i = 0; i < input.ToCharArray().Length; i++)
		{
			cisla[i] = input.ToCharArray()[i];
		}
		Console.WriteLine(GetUnique(cisla));
	}

	static int GetUnique(int[] numbers)
	{
		// Pokud pole má méně než tři čísla, nemůžeme najít unikátní číslo.
		if (numbers.Length < 3)
		{
			Console.WriteLine("Pole musí mít alespoň tři čísla.");
		}

		// Porovnáváme každé číslo s jeho sousedy.
		for (int i = 1; i < numbers.Length - 1; i++)
		{
			if (numbers[i] != numbers[i - 1] && numbers[i] != numbers[i + 1])
			{
				return numbers[i];
			}
		}

		// Pokud jsme prošli celou řadu a nenašli unikátní číslo, můžeme zkontrolovat krajní hodnoty.
		if (numbers[0] != numbers[1])
		{
			return numbers[0];
		}

		if (numbers[numbers.Length - 1] != numbers[numbers.Length - 2])
		{
			return numbers[numbers.Length - 1];
		}

		// Pokud jsme sem došli, pak v řadě není žádné unikátní číslo.
		throw new ArgumentException("V řadě není žádné unikátní číslo.");
	}
}
