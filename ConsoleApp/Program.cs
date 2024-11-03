namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");

            Osoba osoba1 = new Osoba();

            Console.Write("Podaj ID osoby: ");
            int id = int.TryParse(Console.ReadLine(),out int ID) ? ID : 0;
            Console.Write("Podaj imię osoby: ");
            string? Imie = Console.ReadLine();
            Imie = string.IsNullOrEmpty(Imie) ? "" : Imie;

            Osoba osoba2 = new Osoba(id, Imie);

            Osoba osoba3 = new Osoba(osoba2);

            Console.WriteLine("Przywitanie dla obiektu osoba1:");
            osoba1.Przywitanie("Jan");

            Console.WriteLine("Przywitanie dla obiektu osoba2:");
            osoba2.Przywitanie("Jan");

            Console.WriteLine("Przywitanie dla obiektu osoba3:");
            osoba3.Przywitanie("Jan");

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
        }
    }
}
