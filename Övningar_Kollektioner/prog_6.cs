int[,] A = {
    { 85, 90, 78 },
    { 92, 88, 96 },
    { 75, 80, 82 }
};

int[,] B = {
    { 100, 90, 78 },
    { 92, 88, 96 },
    { 75, 200, 82 }
};

bool lika = true; // vi antar först att de är lika

// Kontrollera att dimensionerna stämmer
if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
{
    for (int i = 0; i < A.GetLength(0); i++) // rader
    {
        for (int j = 0; j < A.GetLength(1); j++) // kolumner
        {
            if (A[i, j] != B[i, j])
            {
                lika = false;
                Console.WriteLine($"Skillnad hittad på position [{i},{j}]: {A[i, j]} != {B[i, j]}");
            }
        }
    }
}
else
{
    lika = false;
    Console.WriteLine("Matriserna har olika dimensioner!");
}

if (lika)
    Console.WriteLine("Matriserna är lika!");
else
    Console.WriteLine("Matriserna är inte lika!");
