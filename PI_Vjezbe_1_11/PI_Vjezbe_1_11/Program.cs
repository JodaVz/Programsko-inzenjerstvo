using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite 5 brojeva : ");
            float prviBroj = float.Parse(Console.ReadLine());
            float drugiBroj = float.Parse(Console.ReadLine());
            float treciBroj = float.Parse(Console.ReadLine());
            float cetvrtiBroj = float.Parse(Console.ReadLine());
            float petiBroj = float.Parse(Console.ReadLine());
            Console.WriteLine("Upisali ste sljedece brojeve" +prviBroj+" "+drugiBroj+" "+treciBroj+" "+cetvrtiBroj+" "+petiBroj+"\n");
            Console.WriteLine("Suma svih brojeva iznosi: "+(prviBroj+drugiBroj+treciBroj+cetvrtiBroj+petiBroj)+"Prosjek svih brojeva iznosi: "+((prviBroj+drugiBroj+treciBroj+cetvrtiBroj+petiBroj)/5));
            Console.ReadKey();

        }
    }
}
