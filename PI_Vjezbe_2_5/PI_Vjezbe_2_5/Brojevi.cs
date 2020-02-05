using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_5
{
    class Brojevi
    {
        public int sumaBrojeva { get; set; }
        public List<int> listaBrojeva { get; set; }
        public Brojevi()
        {
            int izbor = 1;
            listaBrojeva = new List<int>();
            while (izbor==1)
            {
               
                Console.WriteLine("Upišite novi broj u listu: ");
                listaBrojeva.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Za nastavak upisa pritisnite 1: ");
                izbor = int.Parse(Console.ReadLine());
                sumaBrojeva = 0;
                
            }
           
        }
        
        public void Ispis(Brojevi broj)
        {
            Console.WriteLine("Kumulativni niz: ");
            foreach (int objekt in broj.listaBrojeva)
            {
                Console.WriteLine("Trenutni element: " + objekt);
                sumaBrojeva = sumaBrojeva + objekt;
                Console.WriteLine("Trenutni kumulativni niz:" + sumaBrojeva);
               
            }

        }
    }
}
