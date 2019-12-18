using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaç adet isim istiyorsunuz");
            byte adet = byte.Parse(Console.ReadLine());
            string[] isimler = new string[adet];

           
           

          
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine($"{i+1}.isim giriniz:");
                isimler[i] = Console.ReadLine();
            }
            Array.Sort(isimler);
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadKey();
        }
    }
}
