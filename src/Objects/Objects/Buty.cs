using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Buty
    {
        public TypObuwia typ;
        public string kolor;
        public float rozmiar;
        public Material material;
        public string klasyfikacja;
        public Plec plec;
        public uint rokProdukcji;
        public uint wodoodpornoscButowTrekingowych;
        public KlasaOchrony klasaOchronnosci;
        public byte sprezystosc;

        public void Display()
        {
            Console.WriteLine($" TYP BUTÓW: {typ}, KOLOR: {kolor}, ROZMIAR: {rozmiar}, MATERIAŁ: { material}, NA CO: { klasyfikacja}, CZYJE: { plec}, ROK PRODUKCJI: { rokProdukcji}, WODOODPORNOŚĆ: { wodoodpornoscButowTrekingowych}, KLASA OCHRONNOŚCI: { klasaOchronnosci}; SPRĘŻYSTOŚĆ: { sprezystosc}" );
        }
    }


    enum TypObuwia
    {
        Sportowe,
        Eleganckie,
        Plazowe
    }

    enum Material
    {
        Skora,
        SkoraEkologiczna,
        Bawelna
    }


    enum Plec
    {
        Kobieta,
        Mezczyzna
    }

    enum KlasaOchrony
    {
        SB,
        S1,
        S2,
        S3,
        S4,
        S5,
        S6,
        S7,
        SBH
    }
}
