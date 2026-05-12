using System;
using System.Collections.Generic;
using System.Text;

namespace KangelaneSamrjakov
{
    // Baasklass
    public class Kangelane : IPaasta
    {
        // Isendiväljad (Privaatse Nähtavusega)
        private string PrivaatneNimi;
        private string PrivaatneAsukoht;

        // MissiooniStaatus Enum
        public MissiooniStaatusEnum MissiooniStaatus { get; set; }

        // Konstruktor
        public Kangelane(string nimi, string asukoht, MissiooniStaatusEnum missiooniStaatus)
        {
            PrivaatneNimi = nimi;
            PrivaatneAsukoht = asukoht;

            MissiooniStaatus = missiooniStaatus;
        }

        // Omadused
        public string Nimi
        {
            get { return PrivaatneNimi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Nimi ei tohi olla tühi!");
                }
                else
                {
                    PrivaatneNimi = value;
                }
            }
        }

        public string Asukoht
        {
            get { return PrivaatneAsukoht; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Asukoht ei tohi olla tühi!");
                }
                else
                {
                    PrivaatneAsukoht = value;
                }
            }
        }

        // Virtual meetodid

        public virtual int Paasta(int ohus) // IPaasta liides meetod
        {
            return (int)Math.Round(ohus * 0.95);
        }

        public virtual string Vormiriietus()
        {
            return "Kostüümi Välimus";
        }

        public virtual string Tervitus()
        {
            return $"Tere kodanik!";
        }
        public override string ToString()
        {
            return $"Hero: {Nimi}, Location: {Asukoht}";
        }
    }
}
