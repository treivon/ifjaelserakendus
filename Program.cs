using System;

namespace MeetodiOtsimineRakendus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod (1-3):");
            string valik = Console.ReadLine();

            if (valik == "1")
            {
                EsimeneMeetod();
            }
            else if (valik == "2")
            {
                TeineMeetod();
            }
            else if (valik == "3")
            {
                KolmasMeetod();
            }
            else
            {
                Console.WriteLine("Vigane valik!");
            }

            Console.ReadLine();
        }

        static void EsimeneMeetod()
        {
            Console.WriteLine("See on esimene meetod, mis lihtsalt teeb faili ekraanile.");
        }

        static void TeineMeetod()
        {
            Console.WriteLine("See on teine meetod, mille sisu saab valida vastavalt vajadusele.");
            Console.WriteLine("Siin võib olla näiteks keerukam loogika või teiste meetodite väljakutsumine.");
        }

        static void KolmasMeetod()
        {
            try
            {
                // Proovime luua faili ebareaalsesse asukohta
                string failiAsukoht = "C:\\Mittetegelik\\Fail.txt";
                using (var fail = System.IO.File.CreateText(failiAsukoht))
                {
                    fail.WriteLine("See on kolmas meetod, mis loob faili, kuid asukohas, kus seda tegelikult pole.");
                }
                Console.WriteLine("Fail loodi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Viga: " + ex.Message);
            }
        }
    }
}
