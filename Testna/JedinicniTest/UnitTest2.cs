using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testna;

namespace JedinicniTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Skladiste s1 = new Skladiste();
            Proizvod p1 = s1.ProvjeraNajveceg(s1.listaProizvoda);
            Assert.IsTrue(p1.Naziv == "cetvrti", "Retardiran si ");



            Skladiste s2 = new Skladiste();
            Proizvod p2;
            p2 = new Proizvod(s2.listaProizvoda[0].Naziv, s2.listaProizvoda[0].Cijena, s2.listaProizvoda[0].Kolicina, s2.listaProizvoda[0].MinimalnaKolicina);
            s2.UpdateListe();
            Assert.IsTrue(p2.Kolicina < s2.listaProizvoda[0].Kolicina, "konju");
        }
    }
}
