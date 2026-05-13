namespace KangelaneSamrjakov
{
    internal class Program
    {
        // Staatiline list kõikide kangelaste hoidmiseks
        static List<Kangelane> kangelased = new List<Kangelane>();

        // Loeb kangelased failist
        static void LoeKangelasedFailist(string failinimi)
        {
            string[] read = File.ReadAllLines(failinimi);

            foreach (string rida in read)
            {
                string[] osad = rida.Split('/');

                string nimi = osad[0].Trim();
                string asukoht = osad[1].Trim();

                // Kui sisaldab *, siis on SuperKangelane
                if (nimi.Contains("*"))
                {
                    nimi = nimi.Replace("*", "");

                    kangelased.Add(
                        new SuperKangelane(
                            nimi,
                            asukoht,
                            MissiooniStaatusEnum.Missioonil
                        )
                    );
                }
                else
                {
                    kangelased.Add(
                        new Kangelane(
                            nimi,
                            asukoht,
                            MissiooniStaatusEnum.Saadaval
                        )
                    );
                }
            }
        }

        static void Main(string[] args)
        {
            // Loeb failist
            LoeKangelasedFailist("andmed.txt");

            Console.WriteLine("=== Kangelaste nimekiri ===");

            foreach (Kangelane k in kangelased)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(k.ToString());
                Console.WriteLine("Päästetud inimesi: " + k.Paasta(1000));
                Console.WriteLine(k.Vormiriietus());
                Console.WriteLine(k.Tervitus());
                Console.WriteLine(k.MissiooniStaatus());
            }

            Console.ReadLine();
        }
    }
}
