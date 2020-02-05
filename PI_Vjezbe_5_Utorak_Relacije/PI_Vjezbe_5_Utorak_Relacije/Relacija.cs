using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_5_Utorak_Relacije
{
    class Relacija
    {
        public string ImeRelacije { get; set; }
        public float KoordinataX { get; set; }
        public float KoordinataY { get; set; }
        public string Ukupno { get; set; }

        public Relacija(string ime,float x,float y)
        {
            this.ImeRelacije = ime;
            this.KoordinataX = x;
            this.KoordinataY = y;
            this.Ukupno = this.ImeRelacije + " = " + this.KoordinataX + ":" + this.KoordinataY;
        }
        public static Relacija IzracunajUdaljenost(Relacija prva,Relacija druga)
        {
            string ime = prva.ImeRelacije + " do " + druga.ImeRelacije;
            float x = Math.Abs(prva.KoordinataX - druga.KoordinataX);
            float y = Math.Abs(prva.KoordinataY - druga.KoordinataY);

             Relacija finalna = new Relacija(ime, x, y);
            return finalna;

        }
        public static string Brzina(Relacija put,Automobil auto)
        {
            float udaljenost = (float)Math.Sqrt((put.KoordinataX * put.KoordinataX) + (put.KoordinataY * put.KoordinataY));
            float brzina = auto.Brzina;
            float vrijeme = udaljenost / brzina; 
            string rezultat = auto.Ime + " brzine " + auto.Brzina + " prođe od " + put.ImeRelacije + " za " + vrijeme + " sati";
            return rezultat;


        }
    }
}
