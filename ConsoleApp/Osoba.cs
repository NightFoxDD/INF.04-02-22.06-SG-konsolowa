using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Osoba
    {
        private int Id;
        private string Imie;

        public static int LiczbaInstancji = 0;
        public Osoba()
        {
            Id = 0;
            Imie = "";
            LiczbaInstancji++;
        }
        public Osoba(int id, string imie)
        {
            Id = id;
            Imie = imie;
            LiczbaInstancji++;
        }
        public Osoba(Osoba osoba)
        {
            Id = osoba.Id;
            Imie = osoba.Imie;
            LiczbaInstancji++;
        }
        public void Przywitanie(string argument)
        {
            if (string.IsNullOrEmpty(Imie))
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {argument}, mam na imię {Imie}");
            }
        }
    }
}
