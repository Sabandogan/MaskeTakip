

using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
       

        SelamVer("Engin");
        SelamVer("Ahmet");
        SelamVer("Ayşe");
        SelamVer();

       
        int sonuc = Topla(6,58);

        //Diziler / Arrays


        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";
        //ogrenciler[3] = "İlker";

        for(int i = 0;i < ogrenciler.Length;i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }


        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" }; 
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;

        foreach (var sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastName = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;



        List<string> yeniSehirler1 = new List<string> { "Ankara 1","İstanbul 1","İzmir 1"};
        yeniSehirler1.Add("Adana 1");

        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }



        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
       
    }

        
    

    static void SelamVer(string isim="isimsiz")
    {

        Console.WriteLine("Merhaba" + " " + isim);
    }

  
    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + sonuc);
        return sonuc;
    }
    
}

