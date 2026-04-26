using System;

namespace TP_MODUL9_103022430005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CovidConfig covid = new CovidConfig();

            Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {covid.config.satuan_suhu}");
            double suhu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
            int hari = Convert.ToInt32(Console.ReadLine());

            bool suhuValid;

            if (covid.config.satuan_suhu == "celcius")
            {
                suhuValid = (suhu >= 36.5 && suhu <= 37.5);
            }
            else
            {
                suhuValid = (suhu >= 97.7 && suhu <= 99.5);
            }

            bool hariValid = (hari < covid.config.batas_hari_deman);

            if (suhuValid && hariValid)
            {
                Console.WriteLine(covid.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(covid.config.pesan_ditolak);
            }

            covid.UbahSatuan();
        }
    }
}