using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_Utorak_Rijeci
{
    class Recenice
    {
        public string Recenica { get; set; }
        
        
        public Recenice(string recenica)
        {
            this.Recenica = recenica;
            
        }
        public int BrojacSlova(string recenica)
        {
            int brojac = 0;
            for (int i = 0; i < this.Recenica.Length; i++)
            {
                if (this.Recenica[i] != ' ') brojac++;
            }
            return brojac;
        }
        public int BrojacRijeci(string recenica)
        {
            int brojac = 0;
            for (int i = 0; i < this.Recenica.Length; i++)
            {
                if (this.Recenica[i] == ' ') brojac++;
            }
            return brojac;
        }
        public string Okretac(string recenica)
        {
            char[] obrnuta = recenica.ToCharArray();
            Array.Reverse(obrnuta);
            return new string(obrnuta);

        }
        
        public int Pretraga(string recenica, string pojam)
        {

            int brojac = 0;

            if (recenica.Contains(pojam))
            {
                brojac++;

            }


            return brojac;




        }
    }
}
