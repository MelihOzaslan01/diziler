// Dizi Tanımlama

string[] renkler = new string[500];
string[] hayvanlar  = { "Kedi", "Köpek", "Tavşan", "Kuş", "Balina" };

int[] dizi;
dizi = new int[25];

// Dizilerde Değer Atama ve Erişim

renkler[0] = "Kırmızı";
dizi[3] = 50;


Console.WriteLine(hayvanlar[2]);
Console.WriteLine(renkler[0]);
Console.WriteLine(dizi[3]);

// Döngülerle Dizi Kullanımı 
// Klavyeden girilen n tane elemanın ortalamasını hesaplayan program 

Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int [diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. Sayıyı Giriniz : " , i+1 );
    sayiDizisi[i] = int.Parse(Console.ReadLine());

}

int toplam = 0;
foreach (var sayi in sayiDizisi)
{
    toplam += sayi;
    

}
Console.WriteLine("Ortalamanız : " + toplam/diziUzunlugu);





