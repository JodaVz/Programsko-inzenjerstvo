using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak
{
    class Pravokutnik
    {
        public float Duzina { get; set; }
        public float Visina { get; set; }
        public float Povrsina { get; set; }
        public float DuljinaDijagonale { get; set; }
        public Pravokutnik(float a, float b)
        {
            this.Duzina = a;
            this.Visina = b;
            this.Povrsina = this.Duzina * this.Visina;
            this.DuljinaDijagonale = IzracunDijagonale(this.Duzina, this.Visina);

        }
        private float IzracunDijagonale(float a, float b)
        {
            float pomocna = 0;
            pomocna = (float)Math.Sqrt((a * a) + (b * b));
            return pomocna;

        }
    }
}
