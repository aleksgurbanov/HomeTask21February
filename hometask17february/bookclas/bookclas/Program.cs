using System;

namespace bookclas
{
    class Program
    {
        static void Main(string[] args)


        {





            string[] kitablar = new string[10];
            



            for (int i = 0; i < kitablar.Length; i++)
            {
                

                Console.WriteLine("kitab adi daxil et");
                string kitab = Console.ReadLine();
                BookClass library = new BookClass(kitab);

                Console.WriteLine("kitabin neche sehifeli oldugunu daxil edin ");
                string sehife = Console.ReadLine();
                int say= int.Parse(sehife);
                BookClass sehifesay = new BookClass(say);               
                
                kitablar[i] = kitab + " " + say;
            }
            foreach (string item in kitablar)
            {
                Console.WriteLine($"kitabin adi {item} sehifelidir");

            }
             
















        }
    }
}
