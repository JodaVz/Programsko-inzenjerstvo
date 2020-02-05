using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testna
{
    public class Skladiste
    {
        public List<Proizvod> listaProizvoda = new List<Proizvod>();

        public Skladiste()
        {
            listaProizvoda.Add(new Proizvod("prvi", 1, 3, 10));
            listaProizvoda.Add(new Proizvod("drugi", 2, 2, 2));
            listaProizvoda.Add(new Proizvod("treci", 3, 3, 3));
            listaProizvoda.Add(new Proizvod("cetvrti", 4, 4, 4));

        }
        public Proizvod ProvjeraNajveceg(List<Proizvod> lista)
        {
            Proizvod najveci = new Proizvod(null, 0, 0, 0);
            foreach (Proizvod item in lista)
            {
                if (item.Cijena*item.Kolicina>najveci.Cijena*najveci.Kolicina)
                {
                    najveci = item;
                }
            }
            return najveci;
        }
        public void UpdateListe()
        {
            foreach (Proizvod item in listaProizvoda)
            {
                if (item.Kolicina<item.MinimalnaKolicina)
                {
                    item.Kolicina = item.MinimalnaKolicina * 2;
                    break;
                }
            }


        }
    }
}
