using System;

class program
{
   static void Main()
   {
      Console.WriteLine("Ders adını girin:");
      
      string dersAdi = Console.ReadLine();
      
      notgiris:
      Console.Write("vize notu girin (0-100)");
      bool vizeok= float.TryParse(Console.ReadLine(), out float vize);
      
      Console.Write("final notu girin (0-100)");
      bool finalok= float.TryParse(Console.ReadLine(), out float final);

      if (!vizeok || !finalok || vize < 0 || vize > 100 || final < 0 || final > 100)
      {
         Console.WriteLine("Hatalı not girdiniz. lütfen 0-100 aralığında bir sayı giriniz");
         goto notgiris;
      }
      
      float ortalama = (vize * 0.4f + final * 0.6f);
      string harfNotu;
      
      if (ortalama >= 50)
         harfNotu = "D";
      else if (ortalama >= 60)
         harfNotu = "C2";
      else if (ortalama >= 65)
         harfNotu = "C1";
      else if (ortalama >= 70)
         harfNotu = "B2";
      else if (ortalama >= 75)
         harfNotu = "B1";
      else if (ortalama >= 85)
         harfNotu = "A1";
      else harfNotu = "A2";
      
      Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: {harfNotu}");
      Console.WriteLine(ortalama >= 50 ? "Geçtiniz" : "Kaldınız");
      
      

   } 
   
    
}