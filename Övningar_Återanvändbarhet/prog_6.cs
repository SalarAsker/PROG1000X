// Be användaren skriva in något
Console.Write("Skriv in något: ");
string input = Console.ReadLine();

// Anropa metoden och skriv resultatet
if (IsWhole(input))
{
    Console.WriteLine("Du skrev in ett heltal.");
}
else
{
    Console.WriteLine("Det du skrev in är inte ett heltal.");
}

// Metoden som avgör om texten är ett heltal
bool IsWhole(string text)
{
    int test = 0;
    return int.TryParse(text, out test);
}