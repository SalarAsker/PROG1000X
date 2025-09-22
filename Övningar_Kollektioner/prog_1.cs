
// Utan loop

int[] dice = new int[6];

Random rnd = new Random();

dice[0] = rnd.Next(1, 7);
dice[1] = rnd.Next(1, 7);
dice[2] = rnd.Next(1, 7);
dice[3] = rnd.Next(1, 7);
dice[4] = rnd.Next(1, 7);
dice[5] = rnd.Next(1, 7);

Console.WriteLine($"{dice[0]}, {dice[1]}, {dice[2]}, " +
    $"{dice[3]}, {dice[4]}, {dice[5]}");

// Med loop
int[] dice = new int[6];
Random rnd = new Random();

// Fyll arrayen med slumptal mellan 1 och 6
for (int i = 0; i < dice.Length; i++)
{
    dice[i] = rnd.Next(1, 7);
}

// Skriv ut alla värden i arrayen
for (int i = 0; i < dice.Length; i++)
{
    Console.Write(dice[i] + (i < dice.Length - 1 ? ", " : ""));
}
