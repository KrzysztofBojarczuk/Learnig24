using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieUzytkownika;

            imieUzytkownika = "Edward";
            int liczbaNieprzeczytanychWiadomosc = 5;
            int liczbaPowiadomien = 7;

            string powitanieUzytkownika = GenerujPowitaniaUzytkownika(imieUzytkownika, liczbaNieprzeczytanychWiadomosc, liczbaPowiadomien);


            Console.WriteLine(powitanieUzytkownika);

        }
        static string GenerujPowitaniaUzytkownika(string imieUzytkownika, int liczbaNieprzeczytanychWiadomosc, int liczbaPowiadomien)
        {
            string output = $"Witaj {imieUzytkownika}! Masz {liczbaNieprzeczytanychWiadomosc} nieprzeczytanych wiadomości oraz {liczbaPowiadomien} powiadomień";
            return output;
        }
            
    }
}
