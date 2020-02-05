using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BinarniBroj> listaBrojeva = new List<BinarniBroj>();
            int velicinaListe = 0;
            Console.WriteLine("Unesite broj binarnih brojeva : " );
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                listaBrojeva.Add(new BinarniBroj());
            }
            
            foreach (BinarniBroj item in listaBrojeva)
            {
                item.NizBitova.Reverse();
                item.BrojDekadski = 0;
                int suma = 0;
                Console.WriteLine("Binarni broj : ");
                for (int i = 0; i <= 7; i++)
                {
                    Console.WriteLine("Bit na indeksu " + i + ". je : " + item.NizBitova[i]);
                }
               
                for (int i = 0; i <= 7; i++)
                {
                    if (item.NizBitova[i] == 1)
                    {
                        
                        if (i == 0)
                        {
                            item.BrojDekadski += 1;
                        }
                        else
                        {
                            item.BrojDekadski += (int)Math.Pow(2, i);
                        }
                    }
                }
                Console.WriteLine("Dekadska reprezentacija broja je : " + item.BrojDekadski);

            }
            Console.ReadKey();


        }
    }
}
