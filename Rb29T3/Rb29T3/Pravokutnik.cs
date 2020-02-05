using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rb29T3
{
    class Pravokutnik
    {
        public int DimenzijaStraniceA { get; set; }
        public int DimenzijaStraniceB { get; set; }
        public string BojaPravokutnika { get; set; }



        public Pravokutnik()
        {

            
            
            try
            {
                
                Console.WriteLine("Koju boju pravokutnika zelite? ");
                this.BojaPravokutnika = Console.ReadLine();
     
                if (this.BojaPravokutnika != "Crvena" && this.BojaPravokutnika != "Plava" && this.BojaPravokutnika != "Zelena")
                {
                    throw new Iznimka("Unesena boja nije podrzana");
                }
                Console.WriteLine("Unesite dimenziju stranice A ");
                this.DimenzijaStraniceA = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite dimenziju stranice B ");
                this.DimenzijaStraniceB = int.Parse(Console.ReadLine());

            }
            catch (Iznimka KrivaBoja)
            {
                Console.WriteLine(KrivaBoja.Poruka);
                
            }
           
           
        }
        public static List<Pravokutnik> Upis()
        {
            List<Pravokutnik> listaPravokutnika = new List<Pravokutnik>();
            Console.WriteLine("Vrsim upis elemenata u listu ");
            string izbor = "Da";
            do
            {
                listaPravokutnika.Add(new Pravokutnik());
                Console.WriteLine("Zelite li jos pravokutnika? ");
                izbor = Console.ReadLine();
            } while (izbor == "Da");

            return listaPravokutnika;
        }
        public static void  Ispis(List<Pravokutnik> listaPravokutnika)
        {
            foreach (Pravokutnik pravokutnik in listaPravokutnika)
            {
                if (pravokutnik.BojaPravokutnika == "Crvena")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                }
                if (pravokutnik.BojaPravokutnika == "Plava")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    
                }
                if (pravokutnik.BojaPravokutnika == "Zelena")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                }
                for (int z = 0; z < pravokutnik.DimenzijaStraniceB; z++)
                {
                    for (int p = 0; p < pravokutnik.DimenzijaStraniceA; p++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine("");
                }

            }
        }
    }
}
