using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
    class Baze
    {
        public string ljevaBaza { get; set; }
        public string desnaBaza { get; set; }
        public List<string> listaBaza { get; set; }


        public string Upis(string prva)
        {
            Baze baza = new Baze();
            baza.ljevaBaza = prva;
            string rezultat = "";
            if (baza.ljevaBaza != "A" || baza.ljevaBaza != "T" || baza.ljevaBaza != "C" || baza.ljevaBaza != "G")
            {

                rezultat = null;
            }
            
            
                if (baza.ljevaBaza == "A")
                {
                    baza.desnaBaza = "T";
                }
                if (baza.ljevaBaza == "T")
                {
                    baza.desnaBaza = "A";

                }
                if (baza.ljevaBaza == "C")
                {
                    baza.desnaBaza = "G";
                }
                if (baza.ljevaBaza == "G")
                {
                    baza.desnaBaza = "C";

                }


                rezultat = baza.ljevaBaza + " - " + baza.desnaBaza;
            
            return rezultat;
    }
        
   }
}
