
Console.WriteLine("1. YÖNTEM:");
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");

Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.Write("Hangi Meyveyi Almak İstersiniz) (Elma/Armut/Çilek/Muz/Diğer): ");
string meyve = Console.ReadLine().ToLower();

if (meyve == "elma")
{
    Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 2 TL dir");
}
else if (meyve == "armut")
{
    Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 3 TL dir");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 2 TL dir");
}
else if (meyve == "muz")
{
    Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 3 TL dir");
}
else
    Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 4 TL dir");


Console.WriteLine("2. YÖNTEM:");
Console.WriteLine("----------------------------------------");


Console.WriteLine("Rüya Manavına Hoş Geldiniz!");

Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.Write("Hangi Meyveyi Almak İstersiniz) (Elma/Armut/Çilek/Muz/Diğer): ");
string meyve2 = Console.ReadLine().ToLower();

switch (meyve2)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 2 TL dir.");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 3 TL dir.");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 2 TL dir.");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı 3 TL dir.");
        break;
    default:
        Console.WriteLine("Seçtiğiniz Meyvenın Fiyatı 4 TL dir.");
        break;
}


//Bence switch-case ile yapmak daha kolay ve daha sade. Oyuzden ben 2. yontemı tercıh ederdim.


