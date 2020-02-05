using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_1_3K
{
    class Brojevi
    {
        public int jedinice { get; set; }
        public int desetice { get; set; }
        

        public void Upis()
        {
            Brojevi broj = new Brojevi();
            Console.WriteLine("Upisite jedinice : ");
            broj.jedinice = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite desetice: ");
            broj.desetice = int.Parse(Console.ReadLine());
            broj.desetice = broj.desetice * 10;
            Console.WriteLine("Konačan rezultat je :"+(broj.jedinice + broj.desetice) * 2);
            
        }

        //ovo dolje je okej, kreso approva
        public static Brojevi Upis2()
        {
            Brojevi brojevi = new Brojevi();
            brojevi.jedinice = 1;
            brojevi.desetice = 2;

            return brojevi;
        }
       


    }
}
