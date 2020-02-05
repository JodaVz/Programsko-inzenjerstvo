using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_Ponedeljak_Palindromi
{
    class Recenice
    {
        public string UlaznaRecenica { get; set; }
        public string IzlaznaRecenica { get; set; }
        public Recenice(string recenica)
        {
            this.UlaznaRecenica = recenica;
            
        }
        public bool ProvjeraPalindroma(string recenica)
        {
            char[] original = recenica.ToCharArray();
            int j = recenica.Length;
            for (int i = 0; i < recenica.Length; i++)
            {
                if (original[i] == original[j-1])
                {
                    return true;
                }
                else return false;
                j--;
            }

            return true;
        }

    }
}
