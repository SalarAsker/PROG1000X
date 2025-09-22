int a = 3, b = 4, c = 4;

Console.WriteLine($"a == b\t{a == b}");   // false
Console.WriteLine($"b == c\t{b == c}");   // true
Console.WriteLine($"c == a\t{c == a}");   // false
Console.WriteLine($"a < b\t{a < b}");     // true
Console.WriteLine($"a > b\t{a > b}");     // false
Console.WriteLine($"b < a\t{b < a}");     // false
Console.WriteLine($"b > a\t{b > a}");     // true
Console.WriteLine($"b <= c\t{b <= c}");   // true
Console.WriteLine($"a <= c\t{a <= c}");   // true
Console.WriteLine($"b >= c\t{b >= c}");   // true
Console.WriteLine($"c <= a\t{c <= a}");   // false
