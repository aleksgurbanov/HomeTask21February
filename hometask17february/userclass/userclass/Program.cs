using System;

namespace userclass
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("istifadeci adini daxil edin");
            string istifadeci = Console.ReadLine();
            Userclass istifadeci1 = new Userclass(istifadeci);



            
            Console.WriteLine("Parolu daxil edin. Diqqet! Parol Boyuk , kichik herfden,  " +
            "ibaret ingilis shirftlerden ibaret olmalidir.");
            string parol = Console.ReadLine();
            istifadeci1.Parol = parol;







            Console.WriteLine("daxil ola bildiniz");
        }
    }
}
