// Girilen metnin harf sayısını Yazıyor
string girilenmetin = "";
Console.WriteLine("Bir Metin Giriniz");
do
{
    girilenmetin = Console.ReadLine();

    if (string.IsNullOrEmpty(girilenmetin)) {
        Console.WriteLine("Gecerli Bir Deger Giriniz");
        girilenmetin= Console.ReadLine();
    }else { break; }
} while (string.IsNullOrEmpty(girilenmetin));
char[] variables =girilenmetin.ToCharArray();
Console.WriteLine(variables.Length);


