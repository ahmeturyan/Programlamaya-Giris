using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13TamBolunenSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 1000; i++)
            {
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
