using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_10
{
    class Brojevi
    {
        public int PrviBroj { get; set; }
        
        public Brojevi()
        {
            Console.WriteLine("Upišite broj : ");
            this.PrviBroj = int.Parse(Console.ReadLine());
       
        }
        public static void Ispis(List<Brojevi> lista,int brojElemenata)
        {
            int suma = 0;
            foreach (Brojevi item in lista)
            {
                suma = suma + item.PrviBroj;
            }
            float prosjekBrojeva = suma / brojElemenata;
            float odstupanje = 0;
            foreach (Brojevi item in lista)
            {
                odstupanje = prosjekBrojeva - item.PrviBroj;
                Console.WriteLine("Prosjek je "+prosjekBrojeva);
                Console.WriteLine("Broj " + item.PrviBroj);
                Console.WriteLine ("odstupa od prosjeka za : "+Math.Abs(odstupanje));
            }
        }
    }
}
