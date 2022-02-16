using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobókocka");
            Random r = new Random();
            int kockaDobottSzam = r.Next(1,7);

            Console.WriteLine(kockaDobottSzam);

            Console.ReadKey();
        }
    }
}
