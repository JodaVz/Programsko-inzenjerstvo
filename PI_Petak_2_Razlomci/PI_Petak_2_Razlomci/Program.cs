using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Petak_2_Razlomci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Razlomci> listaR = new List<Razlomci>();
            listaR = Razlomci.Upis();
            Razlomci.Ispis(listaR);
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Razlomci.Umnozak(listaR);
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Razlomci.Kvocijent(listaR);

            Console.ReadKey();
        }

    }
}
