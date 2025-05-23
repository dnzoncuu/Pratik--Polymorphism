using ConsoleApp12;

SekilHesapla sekilHesapla=new SekilHesapla();//Nesne Oluşturuyoruz

bool devamMı = true;

while (devamMı)//Tekrar Hesaplama Ypıp Yapmayacagını soruyoruz
{
    sekilHesapla.HesaplaMenusu();
    Console.WriteLine("Tekrar denemek ister misin");
    string secim=Console.ReadLine();
    while(secim != "e" && secim != "h")
    {
        Console.WriteLine("Tekrar giriş yapınız");
        secim = Console.ReadLine();
    }

    if(secim == "h") 
    {
       break;
    }
}
 
   

