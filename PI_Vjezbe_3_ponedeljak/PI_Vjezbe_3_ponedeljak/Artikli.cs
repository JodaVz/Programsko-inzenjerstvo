using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_ponedeljak
{
    class Artikli
    {
        public string NazivArtikla { get; set; }
        public float CijenaArtikla { get; set; }
        public Artikli()
        {
            Console.WriteLine("Upišite naziv artikla : ");
            this.NazivArtikla = Console.ReadLine();
            Console.WriteLine(" Upišite cijenu artikla :");
            this.CijenaArtikla = float.Parse(Console.ReadLine());
        }

    }
}
