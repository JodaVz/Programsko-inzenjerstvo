using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_3
{
    class Kalkulator
    {
        public float Broj { get; set; }
        public string Operator { get; set; }
        public static float RezultatOperacije { get; set; }
        public Kalkulator()
        {
            Console.WriteLine("Upišite broj : ");
            this.Broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Odaberite operaciju + - / *");
            this.Operator = Console.ReadLine();
        }
        
    }
}
