// See https://aka.ms/new-console-template for more information


int derece;

Console.WriteLine("Hava sıcaklığını giriniz");
derece = int.Parse(Console.ReadLine());
if (derece >= 10 && derece < 20)
    Console.WriteLine("Normal");
else if (derece >= 20 && derece < 30)
    Console.WriteLine("Sıcak");
else if (derece >= 30 && derece <= 40)
    Console.WriteLine("Çok sıcak");
else
    Console.WriteLine("10 ile 40 arası bir sayı giriniz");
