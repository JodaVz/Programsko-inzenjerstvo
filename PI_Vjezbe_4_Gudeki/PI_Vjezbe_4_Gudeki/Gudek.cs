using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_Gudeki
{
    class Gudek
    {
        public string ImeGudeka { get; set; }
        public int SpolGudek { get; set; }
        public int BojaGudeka { get; set; }
        public Gudek(string ime, int spol, int boja)
        {
            this.ImeGudeka = ime;
            this.SpolGudek = spol;
            this.BojaGudeka = boja;
        }
        public static string FiltriranjePoBoji(List<Gudek> lista,int farba)
        {
            string pofarbanaEkipa = "";
            
            foreach (Gudek item in lista)
            {
                if (item.BojaGudeka==farba)
                {
                    if (item.BojaGudeka==1)
                    {
                        pofarbanaEkipa += "Gudeki koji se zovu: " + item.ImeGudeka + " su crne boje" + Environment.NewLine;
                    }
                    if (item.BojaGudeka==2)
                    {
                        pofarbanaEkipa += "Gudeki koji se zovu: " + item.ImeGudeka + " su sive boje" + Environment.NewLine;
                    }
                    if (item.BojaGudeka==3)
                    {
                        pofarbanaEkipa += "Gudeki koji se zovu: " + item.ImeGudeka + " su roze boje" + Environment.NewLine;
                    }
                    
                }
            }
            return pofarbanaEkipa;
        }
        public static string FiltriranjePoSpolu(List<Gudek> lista, int spol)
        {
            string spoloviGudeka = "";

            foreach (Gudek item in lista)
            {
                if (item.SpolGudek == spol)
                {
                    if (item.SpolGudek == 1)
                    {
                        spoloviGudeka += "Gudeki koji se zovu: " + item.ImeGudeka + " su muski" + Environment.NewLine;
                    }
                    if (item.SpolGudek == 2)
                    {
                        spoloviGudeka += "Gudeki koji se zovu: " + item.ImeGudeka + " su zenski" + Environment.NewLine;
                    }
                    if (item.SpolGudek == 3)
                    {
                        spoloviGudeka += "Gudeki koji se zovu: " + item.ImeGudeka + " su neodređeni" + Environment.NewLine;
                    }

                }
            }
            return spoloviGudeka;
        }

    }
}
