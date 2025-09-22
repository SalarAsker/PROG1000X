//Hela personnummret
long personNummer = 200705249514;

//Tar ut näst sista siffran
long nästSistaSiffran = (personNummer / 10) % 10;

//Kollar om den är delbar med två
double kön = nästSistaSiffran % 2;

Console.WriteLine(kön);