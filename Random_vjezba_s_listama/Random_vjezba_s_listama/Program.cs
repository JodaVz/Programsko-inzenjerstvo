using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_vjezba_s_listama
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje liste integera
            List<int> listaIntegera = new List<int>();
            //jednostavni add u listu, jedanput
            Console.WriteLine("Upišite broj u listu: ");
            listaIntegera.Add(int.Parse(Console.ReadLine()));
            //jednostavan ispis iz liste, jedanput
            //lista ko i polje pocne od 0, i moze se direktno pristupit sa brojem indexa u []
            Console.WriteLine("U listi se nalazi broj: " + listaIntegera[0]);
            //novo instanciranje liste da prebrisemo stare vrijednosti, naziv bude isti
            listaIntegera = new List<int>();
            //add u listu više od jedne vrijednosti
            int pomocnaPrva = 0;
            int provjera = 1;
            while (provjera==1)
            {
                
                Console.WriteLine("Unesite novi broj u listu : ");
                pomocnaPrva = int.Parse(Console.ReadLine());
                listaIntegera.Add(pomocnaPrva);
                Console.WriteLine("Zelite li nastaviti upis(1 ili 0)?");
                provjera = int.Parse(Console.ReadLine());
            }
            //ispis iz liste vise od jedne vrijednosti
            //koristimo foreach petlju, generalno pametno za liste i polja, jer je dosta jednostavnija od samog fora, brze za napisati
            foreach (int broj in listaIntegera)
                //znaci var=tip podataka u listi, item proizvoljno nazovemo objekte unutar liste, u ovom slucaju su tu integeri odnosno brojevi
                // in(u cemu?) pa u nasoj listi, odnosno listaIntegera
                //i rokaj mali!
            {
                Console.WriteLine("Trenutni objekt liste je " + broj);
            }

            //ok picimo dalje, za sad nije bas najjasnije zkj su liste bolje od polja, osim kaj su dinamicke, odnosno, vidli ste da nigde nije napisana njihova duljina
            //e sad, idemo nekej konkretno, umjesto da rokamo dvostruko polje, idemo probati savat dvije vrijednosti na isti index
            //dakle, ocu da dok pozovem listaIntegera[0] da mi ispise kombinaciju brojeva, lets go boyos
            //e sad, malo informacija o klasama, klasa je cookiecutter,a objekt je kolačić otisnut na tjestu u obliku zadanom klasom
            //naša klasa bude dost neformalno napravljena, znaci unutar program.cs-a da se bolje vidi
            //objasnjavam dalje kak pisem
            //-------------------KOPIRANA KLASA U KOMENTARE------------------------
            //    class Brojevi     //klasa se zove brojevi sa velikim prvim slovom po notaciji simple enough
            //{
            //    public int prviBroj { get; set; }     //Ima 2 propertisa, prvi i drugi broj, koji su oba 2 integera
            //    public int drugiBroj { get; set; }
            //    public Brojevi(int a, int b)          //e sad, ovo se zove konstruktor klase u c# ctor+tab+tab,basically metoda istog imena klase koja se poziva dok 
            //prvi put napravimo novi objekt
            //    {                                     //ja njoj prosljeđujem dvije vrijednosti a,b te  ih bindam na objektove propove(prvi i drugi broj) 
            //        this.prviBroj = a;
            //        this.drugiBroj = b;
            //    }
            //}
            //------------------KRAJ KLASE-------------------
            //do sad smo imali listu integera ili List<int> a sad mi ocemo listu objekata klase Brojevi, lest go boyos
            List<Brojevi> listaBrojeva = new List<Brojevi>();
            //sad trebamo te objekte instancirati i istovremeno zapisati, taj dio smo rijesili nasim divnim ctorom, dalje sve ide standardno
            //UPIS U LISTU
             pomocnaPrva = 0;
            int pomocnaDruga = 0;
             provjera = 1;
            while (provjera == 1)
            {

                Console.WriteLine("Unesite prvi broj u listu : ");
                pomocnaPrva = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj u listu : ");
                pomocnaDruga = int.Parse(Console.ReadLine());
                listaBrojeva.Add(new Brojevi(pomocnaPrva, pomocnaDruga));
                Console.WriteLine("Zelite li nastaviti upis(1 ili 0)?");
                provjera = int.Parse(Console.ReadLine());
            }
            //kuis kako kul brija? ne samo da smo slozili dinamiku visine ( lista), vec i dinamiku sirine( mozemo prosiriti klasu do amena i dobiti vise podataka
            // bindanih na jedan objekt. Idemo ispisati sad to 
            //ISPIS IZ LISTE
            foreach (Brojevi parBrojeva in listaBrojeva)
            //znaci var=tip podataka u listi, item proizvoljno nazovemo objekte unutar liste, i sad je razlika u tome sto je TIP podataka objekt tipa klase Brojevi
            // in(u cemu?) pa u nasoj listi, odnosno listaIntegera, ovo je ostalo isto
            //i rokaj mali ZESCE!
            //malo bumo ispis promenili da lici na nekej konkretno
            {
                Console.WriteLine("Trenutne vrijednosti objekta pohranjenog u listi su : " + parBrojeva.prviBroj + " i " + parBrojeva.drugiBroj);
                //jedina razlika tu je da ne pristupamo direktno vrijednosti kao kod integera, vec rokamo objekt.trazena vrijednost, odnosno, parBrojeva.prvi ili drugi broj

            }

            Console.ReadKey();
        }
    }
    class Brojevi
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        public Brojevi(int a,int b)
        {
            this.prviBroj = a;
            this.drugiBroj = b;
        }
    }
}
