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
        public MissiooniStaatusEnum Staatus { get; set; }

        // Konstruktor
        public Kangelane(string nimi, string asukoht, MissiooniStaatusEnum staatus)
        {
            PrivaatneNimi = nimi;
            PrivaatneAsukoht = asukoht;

            Staatus = staatus;
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

        // Paasta
        public virtual int Paasta(int ohus) // IPaasta liides meetod
        {
            return (int)Math.Round(ohus * 0.95);
        }

        // Missiooni Staatus
        public virtual string MissiooniStaatus()
        {
            if (Staatus == MissiooniStaatusEnum.Saadaval)
            {
                return $"{Nimi} on hetkel saadaval.";
            }
            else
            {
                return $"{Nimi} on hetkel missioonil.";
            }
        }

        // Vormiriietus
        public virtual string Vormiriietus()
        {
            return $"{Nimi} kannab tavalist kangelase vormi.";
        }

        // Tervitus
        public virtual string Tervitus()
        {
            return $"Tere kodanik! Mina olen {Nimi}.";
        }

        // ToString
        public override string ToString()
        {
            return $"Hero: {Nimi}, Location: {Asukoht}";
        }
    }
}
