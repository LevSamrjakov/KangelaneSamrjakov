using System;
using System.Collections.Generic;
using System.Text;

namespace KangelaneSamrjakov
{
    // Super Kangelane klass
    public class SuperKangelane : Kangelane
    {
        // Isendiväljad
        private double osavus;
        private static Random rnd = new Random();

        // Konstruktor
        public SuperKangelane(string nimi, string asukoht, MissiooniStaatusEnum staatus)
            : base(nimi, asukoht, staatus)
        {
            // juhuslik väärtus vahemikus [1.0 ; 5.0)
            osavus = rnd.NextDouble() * 4 + 1;
        }

        // Omadused
        public double Osavus
        {
            get { return osavus; }
        }

        //Override Meetodid

        // Override Paasta
        public override int Paasta(int ohus)
        {
            double protsent = 95 + osavus;
            return (int)Math.Round(ohus * protsent / 100);
        }

        // Override Vormiriietus
        public override string Vormiriietus()
        {
            return $"{Nimi} kannab erilist superkangelase kostüümi!";
        }

        // Override Tervitus
        public override string Tervitus()
        {
            return $"Mina olen SUPER {Nimi}! Ma päästan päeva!";
        }

        // Override MissiooniStaatus
        public override string MissiooniStaatus()
        {
            return $"{Nimi} on praegu salajasel missioonil.";
        }

        // Override ToString
        public override string ToString()
        {
            return base.ToString() + $", Osavus: {osavus:F2}";
        }
    }
}
