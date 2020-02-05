using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prijatelji> listaP = new List<Prijatelji>();
            while (1==1)
            {
                Console.WriteLine("1. Upis prijatelja");
                Console.WriteLine("2. Ispis prijatelja");
                Console.WriteLine("3. Ispis prijatelja sortirano prema ocjeni");
                Console.WriteLine("4. Malo si pocistimo da bolje vidimo");
                int odabir = 0;
                odabir = int.Parse(Console.ReadLine());
                if (odabir==1)
                {
                    string ime = "";
                    string prezime = "";
                    float ocjena = 0;
                    Console.WriteLine("Unesite ime frenda: ");
                    ime = Console.ReadLine();
                    Console.WriteLine("Unesite prezime frenda: ");
                    prezime = Console.ReadLine();
                    Console.WriteLine("Unesite ocjenu frenda: ");
                    try
                    {
                        ocjena = float.Parse(Console.ReadLine());
                        if (ocjena <= 0) throw new Iznimka("Ocjena mora biti veca od 0, niko nije tak los");
                    }
                    catch (Iznimka e)
                    {

                        Console.WriteLine(e.DodatnaPoruka);
                    }
                    if (ocjena > 0) listaP.Add(new Prijatelji(ime, prezime, ocjena));
                }
                if (odabir == 2)
                {
                    foreach (Prijatelji item in listaP)
                    {
                        Console.WriteLine("Prijatelj "+item.ImeFrenda+" "+item.PrezimeFrenda+" ima ocjenu "+item.OcjenaFrenda);
                    }
                }
                if (odabir == 3)
                {
                 
                        List<Prijatelji> sortiranaLista = listaP.OrderBy(x => x.OcjenaFrenda).ToList();
                    foreach (Prijatelji item in sortiranaLista)
                    {
                        Console.WriteLine("Prijatelj " + item.ImeFrenda + " " + item.PrezimeFrenda + " ima ocjenu " + item.OcjenaFrenda);
                    }
                }
                if (odabir == 4)
                {
                    Console.Clear();
                }
            }
        }
    }
}
