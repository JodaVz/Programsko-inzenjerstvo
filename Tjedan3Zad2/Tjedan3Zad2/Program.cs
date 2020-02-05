using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjedan3Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int trosak=0;
            string kategorija;
            int izbor = 0;
            List<KategorijeTroškovi> listaKategorijeTroskovi = new List<KategorijeTroškovi>();
            while (true)
            {

                Console.WriteLine("1. Unos");
                Console.WriteLine("2. Ispis po kategoriji i suma");
                Console.WriteLine("9. Izlaz ");
                Console.Write("Vaš izbor: ");
                izbor = int.Parse(Console.ReadLine());

                switch (izbor)
                {
                    case 1:
                        Console.Write("Unesi kategoriju: ");
                        kategorija = Console.ReadLine();
                        Console.Write("Unesi iznos: ");
                        try
                        {
                            trosak = int.Parse(Console.ReadLine());
                            if (trosak <= 0) throw new Iznimka("Trošak ne može biti 0 ili manji od 0!");
                        }
                        //hvata samo moju iznimku
                        catch(Iznimka e)
                        {
                            Console.WriteLine(e.DodatnaPoruka);
                        }
                        //hvata sve ostale iznimke
                        catch
                        {
                            Console.WriteLine("Neispravan unos. Unesite prirodni broj!");
                        }
                        KategorijeTroškovi tmpKatTr = new KategorijeTroškovi(trosak, kategorija);
                        listaKategorijeTroskovi.Add(tmpKatTr);
                        break;
                    case 2:
                        Console.Write("Unesi kategoriju: ");
                        string kat = "";
                        kat = Console.ReadLine();
                        int suma = 0;
                        foreach (var item in listaKategorijeTroskovi)
                        {
                            if (item.Kategorija.Contains(kat))
                            {
                                Console.WriteLine("Iznos: " + item.Trosak);
                                suma += item.Trosak;
                            }
                        }
                        Console.WriteLine("Suma: " + suma);
                        break;
                    default:
                        Console.WriteLine("Nesipravan unos!");
                        break;
                }

            }

        }
    }
}

