using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osobe> listaO = new List<Osobe>();
            while (1==1)
            {
                Console.WriteLine("1. Upis osoba");
                Console.WriteLine("2. Ispis osoba");
                Console.WriteLine("3. Pretraga po imenu");
                Console.WriteLine("4. Cist ekran,duga ljubav");
                int odabir = 0;
                odabir = int.Parse(Console.ReadLine());
                if (odabir==1)
                {
                    string ime = "";
                    string prezime = "";
                    Console.Write("Upišite ime osobe: ");
                    ime = Console.ReadLine();
                    Console.Write("Upišite prezime osobe : ");
                    try
                    {
                        prezime = Console.ReadLine();
                        if ((prezime.Length)<=1) throw new Iznimka("Prezime je prekratko frajeru");
                    }
                    catch (Iznimka e)
                    {
                        Console.WriteLine(e.Poruka);
                        
                    }
                    if (prezime.Length > 1) listaO.Add(new Osobe(ime, prezime));

                }
                if (odabir == 2)
                {
                    foreach (Osobe osoba in listaO)
                    {
                        Console.WriteLine("Osoba " + osoba.Ime + " " + osoba.Prezime + " ima " + osoba.listaBrojeva.Count + " telefonskih brojeva te oni su");
                        foreach (Brojevi broj in osoba.listaBrojeva)
                        {
                            Console.WriteLine(broj.BrojTelefona);
                        }
                    }
                }
                if (odabir == 3)
                {
                    string pretraga = "";
                    Console.WriteLine("Unesite ime za traziti: ");
                    pretraga = Console.ReadLine();
                    foreach (Osobe osoba in listaO)
                    {
                        if (osoba.Ime==pretraga)
                        {


                            Console.WriteLine("Osoba " + osoba.Ime + " " + osoba.Prezime + " ima " + osoba.listaBrojeva.Count + " telefonskih brojeva te oni su");
                            foreach (Brojevi broj in osoba.listaBrojeva)
                            {
                                Console.WriteLine(broj.BrojTelefona);
                            }
                        }
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
