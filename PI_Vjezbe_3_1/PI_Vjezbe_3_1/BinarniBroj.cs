using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_1
{
    class BinarniBroj
    {
        public int[] NizBitova { get; set; }
        public int BrojDekadski { get; set; }
        public BinarniBroj()
        {
            Console.WriteLine("Unesite binarnu reprezentaciju broja do 8 bitova: ");
            NizBitova = new int[8];
            for (int i = 0; i <= 7; i++)
            {
                Console.Write("Upišite bit na indexu " + i + ". ");
                NizBitova[i] = int.Parse(Console.ReadLine());
            }
            
        }
    }

}
