using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List < BrojBoja > listaIspisa = new List<BrojBoja>();
            //imenovanje mora imati smisla,dok neko vidi prvi put kod, listaIspisa mu nist ne znaci. međutim iz naziva listaBrojeva, vec mores nekej iscitat
            //moguce da ju ti koristis samo za ispis, al bolje je davati generalno nazivlje, jer budes ju mozda negde i punil il radil logiku s njom

            int prvaPomocna = 0;
            //ja obicno pomocne varijable instanciram na mjestu gdje treba,samo ubuduce FYI, ovo nije nist krivo, samo dok vidis "XY_pomocna" na pocetku koda si malo wtf
            string drugaPomocna;
            //pametno je odma staviti i stringove na pocetnu vrijednost. int=0 je generalni za int, a varijanta toga u stringu je string=""; odnosno samo "" bez razmaka unutra
            int provjera = 1;
            while (provjera == 1)
            {
                Console.Write("Unesite broj: "); prvaPomocna = int.Parse(Console.ReadLine());
                Console.Write("Unesite boju: "); drugaPomocna = Console.ReadLine();
                listaIspisa.Add(new BrojBoja(prvaPomocna, drugaPomocna));
                Console.Write("Ponoviti unos? (0/1)"); provjera = int.Parse(Console.ReadLine());
            }
            foreach (BrojBoja combo in listaIspisa)
            {
                if (combo.boja == "plava")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (combo.boja == "crvena")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (combo.boja == "zelena")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(combo.broj);
                Console.ResetColor();
            }
            //sve stima do sad
            Console.ReadKey();
        }
    }
    //par stvari kaj se klase tice
    //klasa je obicno imenica, potrudi se da bude simple, tipa BrojBoja je onak? da fuq? Nazovi ju Brojevi ili Boje npr?
    //UVIJEK VELIKO POCETNO SLOVO
    //druga stvar, radi klase u njihovom filu, znaci gore deseno di ti pise
    //ConsoleApp3
    //Properties
    //    References
    //    App.config
    //    Program.cs
    //desni klik na ConsoleApp3 ( ime solutiona) i Add. Skroz dolje ti je class, sve isto napravis, i odma joj spucas naziv
    //primjeti gore skroz u kodu ti pisem class Program. ovaj file u kojem si ti pisao je u stvar Klasa Program, kaj vidis i tam desno pise Program.Cs ( Program.Klasa)
    //nemoj buksati druge klase u file prve klase, ili bilo kakav combo toga

    class BrojBoja
    {
        public int broj { get; set; }
        public string boja { get; set; }
        //kaj se propova tice, uvijek velkim slovom, nisam siguran dal je to kod mene vidljivo jer nisam ciljal na imenovanja, ali samo for future reference

        public BrojBoja(int a, string b)
        {
            this.broj = a;
            this.boja = b;
        }
        //konstruktor je dobar
    }
}
