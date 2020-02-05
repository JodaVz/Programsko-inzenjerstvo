using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Kalkulator
    {
        public double Broj_prvi { get; set; }
        public double Broj_drugi { get; set; }
        public string Operacija { get; set; }
        public double rezultat;

        public Kalkulator()
        {

        }

        public void Izracun()
        {
            switch (Operacija)
            {
                case "+":
                    rezultat = Broj_prvi + Broj_drugi;
                    break;

                case "-":
                    rezultat = Broj_prvi - Broj_drugi;
                    break;
                case "*":
                    rezultat = Broj_prvi * Broj_drugi;
                    break;

                case "/":
                    rezultat = Broj_prvi / Broj_drugi;
                    break;
            }
        }
    }
}
