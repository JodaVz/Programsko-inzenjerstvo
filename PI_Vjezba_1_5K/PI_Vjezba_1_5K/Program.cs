using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_5K
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBroj o = new TextBroj();
            o=o.Mnozenje();
            Console.WriteLine("Upisale ste ovaj broj i ovaj tekst: " + o.broj + " " + o.tekst);
            o.Ispis(o.broj, o.tekst);


        }
    }
}
