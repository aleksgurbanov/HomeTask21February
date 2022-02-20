using System;

namespace productclass
{
    class Program
    {
        static void Main(string[] args)
        {   //bu commitde eger el ile bir mehsul daxil etsem, nece olar deye yazdim.
            //TotalIncome burda hesablanmir chunki sadece bir satish var

            Console.WriteLine("ALmaq istediyiniz mehsulu yazin");
            string mehsul = Console.ReadLine();


            Product mehsul1 = new Product ("Bizon");
            mehsul1.Count = 0;
            mehsul1.Price = 0.7;


            //Product mehsul2 = new Product("Maccofe Capucccino");
            //mehsul2.Count = 10;
            //mehsul2.Price = 0.5;


            //Product mehsul3 = new Product("Winchester Goy Compact");
            //mehsul3.Count = 10;
            //mehsul3.Price = 2.60;


            //Product mehsul4 = new Product("Winston Goy Compact");
            //mehsul4.Count = 0;
            //mehsul4.Price = 3.50;
            //Console.WriteLine($"{mehsul4.Count} anbardaki qaliq.");
            //Console.WriteLine($"{mehsul4.Totalincome} satishdan sonra elde edilen gelir.");
            //mehsul4.Sell();
            //Console.WriteLine($"{mehsul4.Count} anbardaki qaliq");
            //Console.WriteLine($"{mehsul4.Totalincome} satishdan sonra elde edilen gelir");
            //mehsul4.Sell();




            //el ile daxil etdiyim mallari gormek ucun olan neticedir yuxarida dediyim kimi
            Console.WriteLine(mehsul1.Price + "malin qiymeti");
            Console.WriteLine(mehsul1.Totalincome);
            mehsul1.Sell();
            Console.WriteLine(mehsul1.Count + "satishdan sonra anbardaki qaliq");

        }
    }
}
