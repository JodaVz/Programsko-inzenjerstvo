using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_6
{
    class Boje
    {
        public List<Parovi> listaParova { get; set; }
        public  List<Parovi> Upis()
        {
           // Parovi par = new Parovi();
            listaParova = new List<Parovi>();
            int odabir = 1;
            while (odabir==1)
            {
                Console.WriteLine("Upišite željeni tekst :");
               string pomocna1 = Console.ReadLine();
                Console.WriteLine("Upišite željenu boju :");
                string pomocna2 = Console.ReadLine();
                listaParova.Add(new Parovi(pomocna1,pomocna2));


                Console.WriteLine("Za nastavak upisa upišite 1: ");
                odabir = int.Parse(Console.ReadLine());
                

            }
            

            return listaParova;
        }
        public void Ispis(List<Parovi> konacnaLista)
        {
           
            foreach (Parovi par in konacnaLista)
            {
              
                if (par.boja == "crvena")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("U listi se nalaze: " + par.tekst + " i " + par.boja);
                    Console.ResetColor();
                }
                if (par.boja == "plava")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("U listi se nalaze: " + par.tekst + " i " + par.boja);
                    Console.ResetColor();
                }
                if (par.boja == "zelena")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("U listi se nalaze: " + par.tekst + " i " + par.boja);
                    Console.ResetColor();
                }
            }

        }

    }
}
