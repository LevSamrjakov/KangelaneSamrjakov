using System;
using System.Collections.Generic;
using System.Text;

namespace KangelaneSamrjakov
{
    // Baasklass
    public class Kangelane
    {
        // Isendiväljad (Privaatse Nähtavusega)
        private string PrivaatneNimi;
        private string PrivaatneAsukoht;

        // Konstruktor
        public Kangelane(string nimi, string asukoht)
        {
            PrivaatneNimi = nimi;
            PrivaatneAsukoht = asukoht;
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
        public virtual int Paasta(int ohus)
        {
            return (int)Math.Round(ohus * 0.95);
        }

        public virtual string Vormiriietus()
        {
            return "Kostüümi välimus";
        }

        public virtual string Tervitus()
        {
            return "Tere kodanik";
        }

        public virtual string MissiooniStaatus()
        {
            return "Saadaval missioonide jaoks";
        }

        public override string ToString()
        {
            return $"Hero: {PrivaatneNimi}, Location: {PrivaatneAsukoht}";
        }
    }
}
