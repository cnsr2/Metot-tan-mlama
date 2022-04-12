using System;

namespace Metot_tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
         int a = 2;
         int b = 3;

         Console.WriteLine(a+b);

         int sonuc = Topla(a,b);
         Console.WriteLine(sonuc);
         
            

         Metotlar ornek = new Metotlar();
         ornek.ekranaYazdir(Convert.ToString(sonuc));
         ornek.arttırVeTopla(a,b);
         int sonuc2 = ornek.arttırVeTopla(a,b);
         ornek.ekranaYazdir(Convert.ToString(sonuc2));
        }
        static int Topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }
        class Metotlar{
            public void ekranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public int arttırVeTopla(int deger1,int deger2)
            {
                deger1 += 1;
                deger2 += 1;
                return deger1 + deger2;

            }
        }
    }
}
