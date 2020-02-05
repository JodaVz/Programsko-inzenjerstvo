using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Govedo
    {
        public string Naziv { get; set; }
        public char Spol { get; set; }
        public char Boja { get; set; }
        public Govedo(string n, string s, string b)
        {
            Naziv = n;
            if (s == "Muški") Spol = 'M';
            else Spol = 'Ž';
            if (b == "Smeđa") Boja = 'S';
            else Boja = 'C';
        }
    }
}
