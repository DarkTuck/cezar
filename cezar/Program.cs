using System;

namespace cezar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("not Copyrighted by DT");
            //zminne z yekstem jawnym i nie jawnym
            string tekstJawny = "";
            string tekstNieJawny = "";
            //zminne z alfabetem i krokiem
            string alfabet = "aąbcćdeęfghijklłmnńoóprsśtuwyzżź";
            //tekst do szyfrowania
            Console.WriteLine("Podaj długość przestawienia");
            int krok = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj tekst do zaszyfrowania:");
            tekstJawny = Console.ReadLine();
            for(int licznik=0; licznik<tekstJawny.Length; licznik++)
            {
                char znak = tekstJawny[licznik];
                int numerZnaku = alfabet.IndexOf(znak);
                if (numerZnaku == -1)
                {
                    tekstNieJawny += znak;
                } else
                {
                    int nowyNumerZnaku = (numerZnaku + krok) % alfabet.Length;
                    char nowyZnak = alfabet[nowyNumerZnaku];
                    tekstNieJawny += nowyZnak;
                 }
                
            }
            Console.WriteLine(tekstNieJawny);
        }
    }
}
