using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadHamming
{

    //testni brojevi : 11100000,01110000,11000000,00110011
    public static class GlobalMembersProba123
    {
        public static int[][] Hamming;
        public static int[][] Hamming2;
        public static int[] syndrome;

        public static void generiraj_matricu(int r, int duljina)
        {
            int n;
            duljina += 1;
            for (int i = 0; i < r; i++)
            {
                int[] bit = new int[2] { 1, 0 };
                for (int j = 0; j < duljina - 1; j++)
                {
                    n = (int)((duljina) / (Math.Pow(2, (1 + i))));
                    if (bit[0] + bit[1] != duljina && bit[0] == n && bit[1] == n)
                    {
                        bit[0] = bit[1] = 0;
                    }
                    if (bit[0] < n)
                    {
                        Hamming[i][j] = 0;
                        bit[0]++;
                    }
                    else if (bit[1] < n)
                    {
                        Hamming[i][j] = 1;
                        bit[1]++;
                    }
                }
            }        
            for (int i = 0; i < r + 1; i++)
            {
                Hamming[i][duljina - 1] = 0;
            }
            for (int i = 0; i < duljina; i++)
            {
                Hamming[r][i] = 1;
            }
        }

        static int Main()
        {
            int r;
            int[] polje = new int[50];
            string unos = new string(new char[50]);
            Console.Write("Unesite kodirani vektor: ");
            unos = Console.ReadLine();

            for (int i = 0; i < unos.Length; i++)
            {
                polje[i] = (int)unos[i] - 48;
            }
            //!!
            r = (int)(Math.Log10(unos.Length + 1) / Math.Log10(2));
            Console.WriteLine("R je " + r);
            int duljina = (int)Math.Pow(2, r) - 1;
            Hamming = new int[r + 1][];
            for (int i = 0; i < r + 1; i++)
            {
                Hamming[i] = new int[duljina + 1];
            }
            GlobalMembersProba123.generiraj_matricu(r, duljina);
            Console.Write("Ham(");
            Console.Write(r);
            Console.Write(", 2)\nBroj bitova: ");
            Console.Write(duljina);
            Console.Write("\n");
            Console.Write("Kontrolna matrica: \n");
            for (int i = 0; i < r + 1; i++)
            {
                for (int j = 0; j < duljina + 1; j++)
                {
                    Console.Write(Hamming[i][j]);
                    Console.Write(' ');
                }
                Console.Write("\n");
            }

            Hamming2 = new int[duljina + 1][];
            for (int i = 0; i < duljina + 1; i++)
            {
                Hamming2[i] = new int[r + 1];
            }
            for (int i = 0; i < r + 1; i++)
            {
                for (int j = 0; j < duljina + 1; j++)
                {
                    Hamming2[j][i] = Hamming[i][j];
                    
                }
            }
            Console.Write("Kontrolna matrica trans: \n");
            for (int j = 0; j < duljina + 1; j++)
            {
                for (int i = 0; i < r + 1; i++)
                {
                    Console.Write(Hamming2[j][i]);
                    Console.Write(' ');
                }
                Console.Write("\n");
            }
            syndrome = new int[r + 1];
            for (int i = 0; i < r + 1; i++)
            {
                syndrome[i] = 0;
            }
            for (int i = 0; i < r + 1; i++)
            {
                for (int j = 0; j < duljina + 1; j++)
                {
                    if (Hamming2[j][i] != 0 && polje[j] != 0)
                    {
                        syndrome[i] += 1;
                    }
                    if (syndrome[i] >= 2)
                    {
                        syndrome[i] = 0;
                    }
                }
            }
            Console.Write("Sindrom: ");
            for (int i = 0; i < r + 1; i++)
            {
                Console.Write(syndrome[i]);
            }
            int provjera = 0;
            bool postoji_greska = false;
            int greska = 0;
            for (int i = 0; i < r + 1; i++)
            {
                if (syndrome[i] == 1)
                {
                    postoji_greska = true;
                }
            }
            if (postoji_greska)
            {
                for (int i = 0; i < r + 1; i++)
                {
                    greska = greska + (int)(syndrome[i] * Math.Pow(2, r - i));
                    //Console.WriteLine(greska);
                }
               
            
            }

            if (duljina - greska + 1 > 0)
            {
                Console.Write("\nGreska se nalazi na bitu broj: "+greska+"\n");
                if (polje[duljina - greska + 1] == 0)
                {
                    polje[duljina - greska + 1] = 1;

                }
                else if (polje[duljina - greska + 1] == 1)
                {
                    polje[duljina - greska + 1] = 0;

                }

                Console.Write("\nDekodirani vektor: \n");
                for (int i = 0; i < unos.Length; i++)
                {
                    Console.Write(polje[i]);
                }
                Console.Write("\n\n");
            }
            if (duljina - greska + 1 < 0)
            {
                Console.WriteLine("\nIma previse gresaka za ispravak\n");
            }

            


            Console.Read();
            return 0;
        }
    }


}
