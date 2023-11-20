namespace BukkMaraton2019
{
    internal class Program
    {
        static int SzamolasNoiVersenyzo(List<Versenytav> v)
        {
            int db = 0;

            for (int i = 0; i < v.Count; i++)
            {
                if (v[i].Kategoria.Equals("n") && v[i].Rajtszam.Equals("R"))
                {
                    db++;
                }

            }

            return db;
        }


        static void Main(string[] args)
        {
           List<Versenytav> maraton = new List<Versenytav>();

            foreach (var item in File.ReadAllLines(@"../../../src/bukkm2019.txt"))
            {
                maraton.Add(new Versenytav(item));
            }

            foreach (var item in maraton)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("\n5.feladat");

            var f5 = SzamolasNoiVersenyzo(maraton);
            Console.WriteLine($"{f5}");


        }
    }
}