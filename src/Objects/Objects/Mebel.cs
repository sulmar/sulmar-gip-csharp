using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Meble
{
    class Mebel
    {
        public Typ typ;
        public Przeznaczenie przeznaczenie;
        public int wysokosc;
        public int szerokosc;
        public int glebokosc;
        public string kolor;
        public Material material;
        public RodzajMontazu rodzajMontazu;
        public string styl;
        public Stan stan;
        public string rodzajZawiasowSzafki;
        public string krzesloObrotoweWolnostojace;

        public void Wyswietl()
        {
            Console.WriteLine($"{typ} - {przeznaczenie} - {wysokosc}x{szerokosc}x{glebokosc} - {kolor} - {material} - {rodzajMontazu} - {styl} - {stan} - {rodzajZawiasowSzafki} - {krzesloObrotoweWolnostojace}");
        }

    }

    enum Typ
    {
        Szafa,
        Krzesło,
        Obraz,
        Łóżko,
        Sofa
    }
    enum Przeznaczenie
    {
        Salon,
        Kuchnia,
        Łazienka,
        Sypialnia,
        Biuro
    }

    enum Stan
    {
        Używany,
        Nowy
    }

    enum Material
    {
        Plastk,
        Dąb,
        Sosna,
        Płótno
    }

    enum RodzajMontazu
    {
        Wolnostojący,
        Wiszący
    }
}
