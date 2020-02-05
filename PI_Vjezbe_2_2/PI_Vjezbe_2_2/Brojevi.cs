using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_2
{
    class Brojevi
    {
        public int duljinaPolja { get; set; }
        public int[] poljeBrojeva { get; set; }
        public List<int> listaBrojeva { get; set; }
        public int duljinaListe { get; set; }

        //Dio riješenja s poljima
        public int[] Upis()
        {
            Brojevi broj = new Brojevi();
            Console.WriteLine("Upisite duljinu polja:");
            broj.duljinaPolja = int.Parse(Console.ReadLine());
            broj.poljeBrojeva = new int[broj.duljinaPolja];
            for (int i = 0; i < broj.duljinaPolja; i++)
            {
                Console.WriteLine("Upišite vrijednost polja na indexu " + i + " : ");
                broj.poljeBrojeva[i] = int.Parse(Console.ReadLine());
            }

            return broj.poljeBrojeva;
        }
        public void Ispis(int[] nizZnakova)
        {
            Brojevi broj = new Brojevi();
            
            broj.poljeBrojeva = nizZnakova;
            Console.WriteLine("Elementi u polju iznose");
            foreach (int znak in broj.poljeBrojeva)
            {
                
                Console.Write(znak+" , ");
                    
            }


        }

        //Dio riješenja s listama
        public List<int> UpisLista()
        {
            Brojevi broj = new Brojevi();
            Console.WriteLine("Upišite duljinu liste: ");
            broj.duljinaListe = int.Parse(Console.ReadLine());
            
            List<int> lista = new List<int>(broj.duljinaListe);
            for (int i = 0; i < broj.duljinaListe; i++)
            {
                Console.WriteLine("Upišite vrijednost liste na indexu" + i + " : ");
             //   int pomocna = ;
                lista.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Duljina liste je : " + lista.Count);
            broj.listaBrojeva = lista;
            return broj.listaBrojeva;
        }
        public void IspisListe(List<int> lista)
        {
            Brojevi broj = new Brojevi();
            broj.listaBrojeva = lista;
            Console.WriteLine("Elementi u listi iznose");
            foreach (int znak in broj.listaBrojeva)
            {
                Console.Write(znak + " , ");
            }

        }


    }
}
