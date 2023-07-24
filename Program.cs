using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;




namespace Nasledovanie_LAB_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data data1 = new Data(1234567, 336655);
            data1.Print();

            Сirculation circulation1 = new Сirculation( 2000, 1000, 500, 12345678, 336655 );
            
            circulation1.Print();
            Console.WriteLine($"Баланс = {circulation1.Balans()}");
            Console.WriteLine($"Остаток = {circulation1.Remainder()}");

            KartCheck KartCheck1 = new KartCheck(2000, 1000, 500, 3000, 12345678, 336655);
            
            KartCheck1.Print();
            Console.WriteLine($"Баланс = {circulation1.Balans()}");
            Console.WriteLine($"Остаток = {circulation1.Remainder()}");
            
            

            Console.ReadKey();
        }
            
    }
}