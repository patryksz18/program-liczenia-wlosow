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

    }
}