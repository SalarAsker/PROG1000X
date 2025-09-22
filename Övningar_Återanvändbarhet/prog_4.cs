

        int resultat = Potens(2, 3);
        Console.WriteLine($"2 upphöjt till 3 är {resultat}");
   

    int Potens(int bas, int exponent)
    {
        int svar = 1;
        for (int i = 0; i < exponent; i++)
        {
            svar *= bas;
        }
        return svar;
    }
