// Anropa metoden några gånger
Console.WriteLine(Längst("Hej", "Hejsan"));    // Förväntat resultat: Hejsan
Console.WriteLine(Längst("Program", "Kod"));   // Förväntat resultat: Program
Console.WriteLine(Längst("Test", "Bäst"));     // Förväntat resultat: Test (lika långa, returnerar första)

// Metoden
string Längst(string text1, string text2)
{
    if (text1.Length >= text2.Length)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}
