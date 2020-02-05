using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pravokutnik> pravokutnik = new List<Pravokutnik>();
            //upis
            int odabir = 0;
            while (1==1)
            {
                Console.WriteLine("1. Dodaj novi element u listu ");
                Console.WriteLine("2. Ispis svih elemenata ");
                Console.WriteLine("3. Ispis elemenata manjih od X");
                Console.WriteLine("4. Malo si ekrancic ocistimo, ne? ");
                odabir = int.Parse(Console.ReadLine());
                if (odabir==1)
                {
                    float pomocna1 = 0;
                    float pomocna2 = 0;
                    try
                    {



                        Console.WriteLine("Upišite stranicu a");
                        pomocna1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Upišite stranicu b");
                        pomocna2 = float.Parse(Console.ReadLine());
                        if (pomocna1 <= 0 || pomocna2 <=0) throw new Iznimka("Stranice nesmiju biti nula ili manje, da fuq?");
                    }
                    catch (Iznimka e)
                    {
                        Console.WriteLine(e.DodatnaPoruka);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Unesite normalni broj");
                    }
                    if (pomocna1 > 0 && pomocna2 > 0) pravokutnik.Add(new Pravokutnik(pomocna1, pomocna2));
                    
                   
                }
                if (odabir == 2)
                {
                    foreach (Pravokutnik item in pravokutnik)
                    {
                        Console.WriteLine("Dužina stranice je : "+item.Duzina);
                        Console.WriteLine("Visina stranice je : " + item.Visina);
                        Console.WriteLine("Dijagonala pravokutnika : " + item.DuljinaDijagonale);
                        Console.WriteLine("Površina pravokutnika je : " + item.Povrsina);
                    }
                }
                if (odabir == 3)
                {
                    Console.WriteLine("Odaberite parametar pretraživanja");
                    float trazeniElement = 0;
                    trazeniElement = float.Parse(Console.ReadLine());
                    foreach (Pravokutnik item in pravokutnik)
                    {
                        if (trazeniElement<item.Povrsina)
                        {
                            Console.WriteLine("Pravokutnik s povrsinom "+item.Povrsina+" ima vecu povrsinu od "+trazeniElement);
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
