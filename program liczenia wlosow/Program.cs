using System;
namespace SzacowanieWlosowNaGlowie
{
    public class Glowa
    {
        // stale dla domylsnych wartosci obliczen
        private const double SredniaLiczbaWlosow = 100000;
        private const double DomyslnyObwodGlowy = 56.0; // w cm
        private const double DomyslnaWysokoscCzola = 15.0; // w cm
        // prywatne pola
        private double obwodGlowy;
        private double wysokoscCzolla;
        private double gestoscWlosow; // ilosc na cm2
        private double powierzchniaGlowy;
        private double liczbaWlosow;
        //kosntruktor z domyslnymi wartosciami
        public Glowa()
        {
            obwodGlowy = DomyslnyObwodGlowy;
            wysokoscCzolla = DomyslnaWysokoscCzola;
            gestoscWlosow = 100;
            liczbaWlosow = 0;
            powierzchniaGlowy = 0;
        }
        // publiczne metody ustawienia wartosci
        public void UstawObwodGlowy(double obwod)
        {
            obwodGlowy = obwod;
        }
        public void UstawWysokoscCzola(double wysokosc)
        {
            wysokoscCzolla = wysokosc;
        }
        public void UstawGestoscWlosow(double gestosc)
        {
            gestoscWlosow = gestosc;
        }
        // Przeciążona metoda obliczająca liczbę włosów na podstawie gęstości, obwodu i wysokości czoła
        public void ObliczLiczbeWlosow()
        {
            powierzchniaGlowy = (obwodGlowy * wysokoscCzolla) / 2; // uproszczony wzór
            liczbaWlosow = powierzchniaGlowy * gestoscWlosow;
        }
        // Przeciążona metoda obliczająca liczbę włosów na podstawie gęstości i powierzchni głowy
        public void ObliczLiczbeWlosow(double powierzchnia)
        {
            liczbaWlosow = powierzchnia * gestoscWlosow;
        }
        // Metoda do uzyskania szacunkowej liczby włosów
        public double PobierzLiczbeWlosow()
        {
            return liczbaWlosow;
        }
        // Metoda do porównania liczby włosów z przeciętną liczbą
        public double PorownajDoSredniej()
        {
            return ((liczbaWlosow - SredniaLiczbaWlosow) / SredniaLiczbaWlosow) * 100;
        }

        // Metoda resetująca wszystkie wartości do domyślnych
        public void Resetuj()
        {
            obwodGlowy = DomyslnyObwodGlowy;
            wysokoscCzolla = DomyslnaWysokoscCzola;
            gestoscWlosow = 100;
            powierzchniaGlowy = 0;
            liczbaWlosow = 0;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Glowa glowa = new Glowa();

            Console.WriteLine("Program do obliczania szacunkowej liczby włosów na głowie.");
        }
    }
}