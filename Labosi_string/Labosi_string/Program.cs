using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labosi_string
{
    class Program
    {
        static void Main(string[] args)
        {

            int broj = 0;
            string tekst = "";
            string ispis = "";
           //string[] polje;
            Console.WriteLine("Upisite broj ponavljanja: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite tekst: ");
            tekst= Console.ReadLine();
            for (int i = 0; i < broj; i++)
            {
                //Console.Write(tekst);
                ispis+= tekst+",";
            }
            Console.WriteLine(ispis);
            Console.ReadKey();
        }
    }
}
