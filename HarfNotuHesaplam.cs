using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfNotuVerme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notunuzu Girin:");

            int a;
            a = int.Parse(Console.ReadLine());
             if (a >= 0 && a <= 100)
              { }
              else
            
             Console.WriteLine("Notunuzu 0-100 arasında bir değer girin!", a);
            

            if (a <= 100 && a >= 90)
                Console.WriteLine("Harf notunuz A",a);
            else if (a <= 89 && a > 80)
                Console.WriteLine("Harf notunuz B",a);
            else if (a <= 79 && a >= 70)
                Console.WriteLine("Harf notunuz C", a);
            else if (a <= 69 && a >= 60)
                Console.WriteLine("Harf notunuz D", a);
            else if (a <= 59 && a >= 50)
                Console.WriteLine("Harf notunuz E", a);
            else if (a <= 49 && a >= 0)
                Console.WriteLine("Harf notunuz F", a);

           Console.ReadKey();

        }
    }
}
