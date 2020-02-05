using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Boje boje = new Boje();
            boje.Ispis(boje.Upis());
            Console.ReadKey();
        }
    }
}
