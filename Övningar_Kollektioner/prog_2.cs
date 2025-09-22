double[] someNumbers = new double[4];

Console.WriteLine("Du ska ange fyra flyttal!!");

// Läs in tal med en loop
for (int i = 0; i < someNumbers.Length; i++)
{
    Console.Write("Ange ett flyttal: ");
    someNumbers[i] = double.Parse(Console.ReadLine());
}

// Skriv ut alla tal
for (int i = 0; i < someNumbers.Length; i++)
{
    Console.Write(someNumbers[i] + " ");
}
