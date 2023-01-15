using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaStringVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program u kojem ćete definirati sljedeće dvije varijable tipa string:
                • s1 sa sadržajem "Hrvatska ima more"
                • s2 sa sadržajem "Italija je prvak svijeta"
              Definirajte i ispišite string s3 čiji će sadržaj biti prvih 8 znakova stringa s1 plus svi znakovi od
              sedmog do kraja niza s2.*/

            Console.WriteLine("----- ZADATAK 1 -----");
            string s1 = "Hrvatska ima more", s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0,8) + s2.Substring(7);
            Console.WriteLine(s3);


            /*Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak
              zamijeniti znakom '_'.*/

            Console.WriteLine("\n----- ZADATAK 2 -----");
            string znakovi;
            Console.WriteLine("Unesi niz znakova: ");
            znakovi = Console.ReadLine();
            Console.WriteLine("Novi niz sa zamjenjenim znakovima: " + znakovi.Replace(" ", "_"));


            /*Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova, te ćete definirati
              sljedeće varijable:
                • sVelika koja će sadržavati unešeni niz pretvoren u velika slova
                • sMala koja će sadržavati unešeni niz pretvoren u mala slova
                • sPrvaTri koja će sadržavati prva tri znaka unešenog niza
                • sZadnjihPet koja će sadržavati zadnjih pet znakova unešenog niza
                • s8_11 koja će sadržavati od 8. do 11. znaka unešenog niza
              Na kraju i ispišite vrijednosti navedenih varijabli.*/

            Console.WriteLine("\n----- ZADATAK 3 -----");
            string znakovi2;
            Console.WriteLine("Unesi niz znakova: ");
            znakovi2 = Console.ReadLine();
            string sVelika = znakovi2.ToUpper();
            string sMala = znakovi2.ToLower();
            string sPrvaTri = znakovi2.Substring(0,3);
            string sZanjihPet = znakovi2.Substring(znakovi2.Length - 5);
            string s8_11 = znakovi2.Substring(8,3);
            Console.WriteLine("Svi znakovi velikim slovima: " + sVelika);
            Console.WriteLine("Svi znakovi malim slovima: " + sMala);
            Console.WriteLine("Prva tri znaka: " + sPrvaTri);
            Console.WriteLine("Zadnjih pet znakova: " + sZanjihPet);
            Console.WriteLine("String od 8. do 11. znaka: " + s8_11);


            /*Napišite program koji će zatražiti od korisnika da unese neku rečenicu te će ispisati prvu i
              zadnju riječ te rečenice.*/

            Console.WriteLine("\n----- ZADATAK 4 -----");
            string recenica;
            Console.WriteLine("Unesi recenicu: ");
            recenica = Console.ReadLine();
            string[] rijeci = recenica.Split(' ');
            Console.WriteLine("Prva rijec: " + rijeci[0] + "\nZadnja rijec: " + rijeci[rijeci.Length-1]);


            /*Napišite program u kojem ćete zatražiti od korisnika da unese jedan cijeli i jedan decimalni
              broj odvojene razmakom. Dvostruke vrijednosti unešenih brojeva spremite u odgovarajuće
              varijable x i y, te ih ispišite.*/

            Console.WriteLine("\n----- ZADATAK 5 -----");
            string niz;
            Console.WriteLine("Unesi jedan cijeli i jedan decimalni broj odvojen razmakom: ");
            niz = Console.ReadLine();
            string[] brojevi = niz.Split(' ');
            double x = Convert.ToDouble(brojevi[0]);
            double y = Convert.ToDouble(brojevi[1]);
            Console.WriteLine("X vrijednost: " + x);
            Console.WriteLine("Y vrijednost: " + y);
            Console.ReadKey();
        }
    }
}
