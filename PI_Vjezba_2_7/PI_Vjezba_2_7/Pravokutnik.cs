using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_2_7
{
    class Pravokutnik
    {
        public int Duzina { get; set; }
        public int Sirina { get; set; }
        public string Boja { get; set; }
        public Pravokutnik()
        {
            Console.WriteLine("Upišite dužinu pravokutnika: ");
            this.Duzina = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite širinu pravokutnika: ");
            this.Sirina = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite boju pravokutnika(crvena,plava,zelena): ");
            this.Boja = Console.ReadLine();
        }
        public static List<Pravokutnik> Upis()
        {
            List<Pravokutnik> listaPravokutnika = new List<Pravokutnik>();
            Console.WriteLine("Koliko pravokutnika zelite?");
            int brojPravokutnika = int.Parse(Console.ReadLine());
            for (int i = 0; i < brojPravokutnika; i++)
            {
                listaPravokutnika.Add(new Pravokutnik());
            }
            return listaPravokutnika;


        }
        public static void Ispis(List<Pravokutnik> lista)
        {
            while (1 == 1)
            {


                foreach (Pravokutnik item in lista)
                {
                    if (item.Boja == "crvena")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (item.Boja == "plava")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (item.Boja == "zelena")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }




                    for (int i = 1; i <= item.Duzina; i++)
                    {
                        for (int j = 1; j < item.Sirina; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("X");
                       
                    }
                    
                    System.Threading.Thread.Sleep(1000);
                }
                

            }
        }
    }
}
